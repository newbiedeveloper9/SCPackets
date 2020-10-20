using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Packets.Login
{
    [PacketRequest(typeof(LoginRequest))]
    public class LoginResponse : ResponsePacket
    {
        public LoginResponse(LoginResult result, LoginRequest request)
            : base(request)
        {
            Result = result;
        }

        public PreviewLogin Data { get; set; } = new PreviewLogin();

        public LoginResult Result { get; set; }
        public string AuthenticationKey { get; set; }
    }
}
