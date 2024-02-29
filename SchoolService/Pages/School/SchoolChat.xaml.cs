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
            //write your ip address in here 
            .WithUrl("http://192.168.91.41:5172/chat")
            .WithAutomaticReconnect()
            .Build();
        _connection.On<string>("MessageReceived" , (message) =>
        {
            ChatMessage.Text += $"{Environment.NewLine}{message}";
        });
        
        

         Task.Run(() =>
             {
                 Dispatcher.Dispatch(async () =>
                     await _connection.StartAsync());
             }
         );

    }

    private async void SendMessage_OnClicked(object sender, EventArgs e)
    {
        try
        {
            object[] obj = new object[] { MyChatMessage.Text };

            await _connection.InvokeCoreAsync("SendMessage" , args: obj);
            MyChatMessage.Text = String.Empty;
        }
        catch (Exception exception)
        {
            DisplayAlert("w", exception.ToString(), "s");
        }
    }
    
}