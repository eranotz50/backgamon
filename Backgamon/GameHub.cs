using Microsoft.AspNet.SignalR;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Backgamon
{
    public class GameHub : Hub
    {
        public void Send(string msg)
        {
            Debug.WriteLine(msg);
        }

        public override Task OnConnected()
        {
            Debug.WriteLine("Connected");
            return base.OnConnected();
        }
    }
}