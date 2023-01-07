using Microsoft.AspNetCore.SignalR.Client;
using RestSharp;
using System.Text;

namespace Lister
{
    public record Token(string Bearer);
    public class User
    {
        public string Name { get; set; }
    }
    public partial class Main : Form
    {
        HubConnection connection;
        string token;
        StringBuilder sbp = new();
        StringBuilder sbg = new();
        List<User> userList = new()
        {
            new User() { Name="qwe" },
            new User() { Name = "ewq" }
        };

        public Main()
        {
            InitializeComponent();

            chats.AutoGenerateColumns = true;
            chats.DataSource = userList;

            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5254/chat", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                }).Build();


            connection.On<string>("Receive", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    sbg.Clear().Append(chatbox.Text);
                    chatbox.Text = string.Empty;
                    chatbox.AppendText($"{username.Text}: {message}\n");
                });
            });

            connection.On<string>("Notify", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{message}\n");
                });
            });

            connection.On<string>("ReceiveGroup", message =>
            {
                chatbox.BeginInvoke(() =>
                {
                    sbp.Clear().Append(chatbox.Text);
                    chatbox.Text = string.Empty;
                    chatbox.AppendText($"{message}\n");
                });
            });
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("Send", inputbox.Text, users?.SelectedItem?.ToString());
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }
        }

        private async void login_Click(object sender, EventArgs e)
        {
            userList.Add(new User() { Name = "test" });
            chats.DataSource = null;
            chats.DataSource = userList;
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
            try
            {
                await connection.InvokeAsync("Enter", groupName.Text);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }
        }

        private async void sendToGroup_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("SendGroup", inputbox.Text, groupName.Text);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }
        }

        private void privateChats_Click(object sender, EventArgs e)
        {
            sbg.Clear().Append(chatbox.Text);
            chatbox.Text = string.Empty;
            chatbox.AppendText(sbp.ToString());
        }

        private void Groups_Click(object sender, EventArgs e)
        {
            sbp.Clear().Append(chatbox.Text);
            chatbox.Text = string.Empty;
            chatbox.AppendText(sbg.ToString());
        }
    }
}