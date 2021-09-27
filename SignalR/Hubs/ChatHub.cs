using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string userId)
        {
            await Clients.User(userId).SendAsync("ReceiveMessage", $"this is private message from {user}: {message}");
            //await Clients.All.SendAsync("ReceiveMessage", user, userId);
        }
    }
}
