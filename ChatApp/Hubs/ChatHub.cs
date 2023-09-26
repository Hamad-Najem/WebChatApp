using Microsoft.AspNetCore.SignalR;
using System.Globalization;

namespace ChatApp.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user,string message)
        { 
            Clients.All.SendAsync("ReceiveMessage", user, message, DateTime.Now.ToString("hh:mm") + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture));
        }
    }
}
