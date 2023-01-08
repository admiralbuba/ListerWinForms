global using static Lister.Program;
using Flurl;
using Flurl.Http;
using Lister.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text;

namespace Lister
{
    public partial class Main : Form
    {
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

            users.ForEach(x => { chats.Items.Add(x); });

            connection = new HubConnectionBuilder()
                .WithUrl(AppSettings.BaseUrl + AppSettings.HubEndpoint, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .WithAutomaticReconnect()
                .Build();

            connection.On<HubMessage>("Receive", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message?.ToName}: {message.Text}");
                });
                chatsData[message?.ToName]?.Append($"{username.Text}: {message.Text}");
            });

            connection.On<string>("Notify", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message}\n");
                });
                chatsData["service"]?.Append($"{message}\n");
            });

            connection.On<HubMessage>("ReceiveGroup", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message.ToName}: {message.Text}");
                });
                chatsData[message.ToName]?.Append($"{message.ToName}: {message.Text}");
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
            chatbox.BeginInvoke(() =>
            {
                chatbox.AppendText($"Token received\n");
                chatbox.AppendText($"Bearer: {token}\n");
            });

            chatsData["service"]?.Append($"Token received\n");
            chatsData["service"]?.Append($"Bearer: {token}\n");
        }
        private async void joinGroup_Click(object sender, EventArgs e)
        {
            var form = new NewGroup();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            var msg = new HubMessage() { ToName = form.GroupName, IsGroup = true };
            try
            {
                await connection.InvokeAsync("Enter", msg);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}");
            }

            chats.Items.Add(form.GroupName);
            if (!chatsData.ContainsKey(form.GroupName)) chatsData.Add(form.GroupName, new StringBuilder());
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

            var msg = new HubMessage() { ToName = selected, Text = inputbox.Text };
            try
            {
                await connection.InvokeAsync($"Send{pstfix}", msg);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}");
            }

            if (!chatsData.ContainsKey(selected)) chatsData.Add(selected, new StringBuilder());
            else chatsData[selected].Append($"{msg.Text}\n");
            chatbox.AppendText($"{msg.Text}\n");
        }

        private async void connect_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.StartAsync();
                statusbar.Items[0].Text = $"Connection: {connection.State}";

            }
            catch (Exception ex)
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{ex.Message}\n");
                });
            }
        }
    }
}