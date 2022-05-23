using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace F1.SignalR
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await this.Clients.All.SendAsync("Send", message, userName);
        }
    }
}
