using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Packets.AuthKeyLogin
{
    [PacketRequest(typeof(AuthKeyLoginRequest))]
    public class AuthKeyLoginResponse : ResponsePacket
    {
        public AuthKeyLoginResponse(AuthKeyLoginResult result ,AuthKeyLoginRequest packet) : base(packet)
        {
            Result = result;
        }

        public AuthKeyLoginResult Result { get; set; }

        public PreviewLogin Data { get; set; } = new PreviewLogin();
    } 
}
