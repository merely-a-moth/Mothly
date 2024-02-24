using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace Mothly_App.Hubs
{
    public class ControlHub : Hub
    {
        /*public async Task SendMessage(string user, string message)
        {
            await Clients.AllExcept(user).SendAsync("ReceiveMessage", user, message);
        }*/

        public async Task SendUpdateMobile(Guid id, PointF newPosition)
        {
            await Clients.All.SendAsync("UpdateMobile", id, newPosition);
        }

        public async Task SendAddMobile(Guid id, PointF newPosition)
        {
            await Clients.All.SendAsync("AddMobile", id, newPosition);
        }
    }
}