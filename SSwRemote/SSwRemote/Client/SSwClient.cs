using System.Threading.Tasks;

namespace SSwRemote.Client
{
    public class SSwClient : MapleClient
    {
        public async Task<bool> TurnOnAsync(ServerItem server)
        {
            return (await SendCommandAsync("TurnOn", server.IpAddress));
        }

        public async Task<bool> TurnOffAsync(ServerItem server)
        {
            return (await SendCommandAsync("TurnOff", server.IpAddress));
        }

        public async Task<bool> TransferFile(ServerItem server)
        {
            return (await SendCommandAsync("TransferFile", server.IpAddress));
        }

    }
}