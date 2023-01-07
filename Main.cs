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
        List<string> users = new() { "qwe", "ewq" };
        Dictionary<string, StringBuilder> chatsData = new()
        {
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
                    chatbox.AppendText($"{username.Text}: {message.Text}\n");
                });
            });

            connection.On<HubMessage>("Notify", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message.Text}\n");
                });
            });

            connection.On<HubMessage>("ReceiveGroup", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message.FromName}: {message.Text}\n");
                });
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

            if (chatsData.ContainsKey(chatName)) chatsData[chatName]?.Append(inputbox.Text);
            else chatsData.Add(chatName, new StringBuilder(inputbox.Text));

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
        }
    }
}