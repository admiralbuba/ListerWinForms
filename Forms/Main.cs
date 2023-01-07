using Lister.Configuration;
using Lister.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System.Text;
using Flurl;
using Flurl.Http;

namespace Lister
{
    public partial class Main : Form
    {
        AppSettings Config => Program.AppSettings;
        HubConnection connection;
        string token;
        List<string> users = new() { "qwe", "ewq" };
        Dictionary<string, StringBuilder> chatsData = new()
        {
            { "service", new StringBuilder() },
            { "qwe", new StringBuilder() },
            { "ewq", new StringBuilder() }
        };

        public Main()
        {
            InitializeComponent();

            users.ForEach(x => { chats.Items.Add(x); });

            connection = new HubConnectionBuilder()
                .WithUrl(Config.BaseUrl + Config.HubEndpoint, options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .WithAutomaticReconnect()
                .Build();

            connection.On<HubMessage>("Receive", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message?.ToName}: {message.Text}\n");
                });
                chatsData[message?.ToName]?.Append($"{username.Text}: {message.Text}\n");
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
                    chatbox.AppendText($"{message.ToName}: {message.Text}\n");
                });
                chatsData[message.ToName]?.Append($"{message.ToName}: {message.Text}\n");
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
            var resp = await Config.BaseUrl
                .AppendPathSegment(Config.AuthEndpoint)
                .SetQueryParam("name", username.Text)
                .PostAsync();

            var data = await resp.GetJsonAsync<Token>();
            token = data.Bearer;
            try
            {
                await connection.StartAsync();
                statusbar.Items[0].Text = $"Connection: {connection.State}";
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"Token received\n");
                    chatbox.AppendText($"Bearer: {token}\n");
                });
            }
            catch (Exception ex)
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{ex.Message}\n");
                });
            }

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
                chatbox.AppendText($"{ex.Message}\n");
            }

            chats.Items.Add(form.GroupName);
            if (!chatsData.ContainsKey(form.GroupName)) chatsData.Add(form.GroupName, new StringBuilder());
        }

        private void chats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = chats?.SelectedItem?.ToString();
            if (selected != null && chatsData.TryGetValue(selected, out StringBuilder sb))
            {
                chatbox.Text = "";
                chatbox.AppendText($"{sb}\n");
            }
        }

        private void saved_Click(object sender, EventArgs e)
        {
            var saved = chatsData["service"].ToString();
            chatbox.Text = "";
            chatbox.AppendText($"{saved}\n");
        }

        private async void Send()
        {
            var chatName = chats?.SelectedItem?.ToString();
            string pstfix = "";

            if (!users.Contains(chats?.SelectedItem?.ToString()))
                pstfix = "Group";

            var msg = new HubMessage() { ToName = chatName, Text = inputbox.Text };
            try
            {
                await connection.InvokeAsync($"Send{pstfix}", msg);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }

            if (!chatsData.ContainsKey(chatName)) chatsData.Add(chatName, new StringBuilder());
        }
    }
}