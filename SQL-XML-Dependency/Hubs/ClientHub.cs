using Microsoft.AspNetCore.SignalR;

namespace SQL_XML_Dependency.Hubs
{
    public class ClientHub:Hub
    {
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        //public async Task SendMessage(string connectionId,string message)
        //{
        //    Clients.Client(connectionId).SendCoreAsync();
        //}

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}
