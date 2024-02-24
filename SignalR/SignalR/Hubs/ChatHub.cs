using Microsoft.AspNetCore.SignalR;
namespace SignalR.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("Recive Message", message);
        }
    }
}
