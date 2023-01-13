global using static Lister.Program;
using Flurl;
using Flurl.Http;
using Lister.Extensions;
using Lister.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text;

namespace Lister
{
    public partial class Main : Form
    {
        CancellationTokenSource cts;
        HubConnection connection;
        string token;
        List<string> users = new() { "qwe", "ewq", "Katy", "Dua" };
        Dictionary<string, StringBuilder> chatsData = new()
        {
            { "service", new StringBuilder() },
            { "qwe", new StringBuilder() },
            { "ewq", new StringBuilder() },
            { "Katy", new StringBuilder() },
            { "Dua", new StringBuilder() }
        };
        string? selected => chats?.SelectedItem?.ToString();

        public Main()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
            var a = new List<string>();

            users.ForEach(x => { chats.Items.Add(x); });

            connection = new HubConnectionBuilder()
                .WithUrl(AppSettings.BaseUrl + AppSettings.HubEndpoint, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .WithAutomaticReconnect()
                .Build();

            statusbar.Items[0].Text = $"Connection: {connection.State}";

            connection.On<MessageDto>("Receive", message =>
            {
                chatbox.BeginAppendText($"{message.ToName}: {message.Text}\n");
                chatsData[message.ToName].Append($"{message.ToName}: {message.Text}\n");
            });

            connection.On<string>("Notify", message =>
            {
                chatbox.BeginAppendText($"{message}\n");
                chatsData["service"]?.Append($"{message}\n");
            });

            connection.On<MessageDto>("ReceiveGroup", message =>
            {
                chatbox.BeginAppendText($"{message.ToName}: {message.Text}\n");
                chatsData[message.ToName].Append($"{message.ToName}: {message.Text}\n");
            });

            connection.Reconnecting += error =>
            {
                statusbar.Items[0].Text = $"Connection: {connection.State}";
                return Task.CompletedTask;
            };
        }

        private async void sendButton_Click(object sender, EventArgs e) => Send();
        private async void inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) Send();
        }

        private async void login_Click(object sender, EventArgs e)
        {
            var resp = await AppSettings.BaseUrl
                .AppendPathSegment(AppSettings.AuthEndpoint)
                .SetQueryParam("name", username.Text)
                .PostAsync();

            var data = await resp.GetJsonAsync<Token>();
            token = data.Bearer;

            chatbox.BeginAppendText($"Token received\nBearer: {token}\n");
            chatsData["service"]?.Append($"Token received\n");
            chatsData["service"]?.Append($"Bearer: {token}\n");
        }
        private async void joinGroup_Click(object sender, EventArgs e)
        {
            string groupName;

            using (var form = new NewGroup())
            {
                if (form.ShowDialog(this) == DialogResult.Cancel)
                    return;
                var users = form.Users;
                groupName = form.GroupName;
            }
            try
            {
                await connection.InvokeAsync("Enter", groupName);
                chats.Items.Add(groupName);
                if (!chatsData.ContainsKey(groupName)) chatsData.Add(groupName, new StringBuilder());
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}");
            }
        }

        private void chats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selected != null && chatsData.TryGetValue(selected, out StringBuilder sb))
            {
                chatbox.Text = "";
                chatbox.AppendText($"{sb}");
            }
        }

        private void saved_Click(object sender, EventArgs e)
        {
            var saved = chatsData["service"].ToString();
            chatbox.Text = "";
            chatbox.AppendText($"{saved}");
        }

        private async void Send()
        {
            string pstfix = "";

            if (!users.Contains(selected))
                pstfix = "Group";

            try
            {
                await connection.InvokeAsync($"Send{pstfix}", new MessageDto(selected, inputbox.Text));
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}");
            }

            if (!chatsData.ContainsKey(selected)) chatsData.Add(selected, new StringBuilder());
            else chatsData[selected].Append($"{username.Text}: {inputbox.Text}\n");
            chatbox.AppendText($"{username.Text}: {inputbox.Text}\n");
        }

        private async void connect_Click(object sender, EventArgs e)
        {
            if (connection.State == HubConnectionState.Connecting)
            {
                cts.Cancel();
                cts = new CancellationTokenSource();
                return;
            }

            else if (connection.State == HubConnectionState.Connected
                || connection.State == HubConnectionState.Reconnecting)
            {
                await connection.StopAsync();
                connect.Image = Properties.Resources.off;
                statusbar.Items[0].Text = $"Connection: {connection.State}";
                return;
            }

            try
            {
                statusbar.Items[0].Text = $"Connection: {HubConnectionState.Connecting}";
                await connection.StartAsync(cts.Token);
                connect.Image = Properties.Resources.green;
                statusbar.Items[0].Text = $"Connection: {connection.State}";
            }
            catch (Exception ex)
            {
                statusbar.Items[0].Text = $"Connection: {connection.State}";
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{ex.Message}\n");
                });
            }
        }
    }
}