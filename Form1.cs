using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System.Windows.Forms;

namespace Lister
{
    public partial class Main : Form
    {
        HubConnection connection;
        string token;
        public Main()
        {
            InitializeComponent();

            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5254/chat", options =>
                {
                    //options.Headers.Add("Authorization", token);
                    options.AccessTokenProvider = () => Task.FromResult(token);
                }).Build();


            connection.On<string, string>("Receive", (user, message) =>
            {
                chatbox.BeginInvoke(() =>
                {
                    chatbox.AppendText($"{user}: {message}\n");
                });
            });
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("Send", username.Text, inputbox.Text);
            }
            catch (Exception ex)
            {
                chatbox.AppendText($"{ex.Message}\n");
            }
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
                    chatbox.AppendText($"{username.Text}: token received\n");
                    chatbox.AppendText($"Token: {token}\n");
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

        private void login_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
    public record Token(string Bearer);
}