using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SchoolService.Pages.School;

public partial class SchoolChat : ContentPage
{
    private readonly HubConnection _connection;
    public SchoolChat()
    {
        InitializeComponent();
        _connection = new HubConnectionBuilder()
            .WithUrl("http://192.168.1.50:5172/chat")
            .Build();
        _connection.On<string>("MessageRecieved" , (message) =>
        {
            chatMessages.Text += $"{Environment.NewLine}{message}";
        });
        Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                    await _connection.StartAsynch());
            }
        );
    }

    private async void SendMessage_OnClicked(object sender, EventArgs e)
    {
        await _connection.InvokeCoreAsync("SendMessage" , EventArgs: new[]{MyChatMessage.Text});
        MyChatMessage.Text = String.Empty;
    }
}