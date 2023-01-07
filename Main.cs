using Lister.Models;
using Microsoft.AspNetCore.SignalR.Client;
using RestSharp;
using System.Text;

namespace Lister
{
    public partial class Main : Form
    {
        HubConnection connection;
        string token;
        List<string> users = new() { "service", "qwe", "ewq" };
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
                .WithUrl("http://localhost:5254/chat", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                }).Build();

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
        }

        private async void sendButton_Click(object sender, EventArgs e)
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

        private async void login_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5254");
            var req = new RestRequest("/login/auth", Method.Post).AddQueryParameter("name", username.Text);
            var resp = await client.ExecuteAsync<Token>(req);
            token = resp.Data?.Bearer;
            try
            {
                await connection.StartAsync();
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
            var msg = new HubMessage() { ToName = groupName.Text, IsGroup = true };
            try
            {
                await connection.InvokeAsync("Enter", msg);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }

            chats.Items.Add(groupName.Text);
            if (!chatsData.ContainsKey(groupName.Text)) chatsData.Add(groupName.Text, new StringBuilder());
        }

        private void chats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = chats?.SelectedItem?.ToString();
            if (selected != null && chatsData.TryGetValue(selected, out StringBuilder sb))
            {
                chatbox.Text = "";
                chatbox.AppendText($"{sb.ToString()}\n");
            }
        }
    }
}