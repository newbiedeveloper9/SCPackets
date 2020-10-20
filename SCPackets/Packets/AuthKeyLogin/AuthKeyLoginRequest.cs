using Network.Packets;

namespace SCPackets.Packets.AuthKeyLogin
{
    public class AuthKeyLoginRequest : RequestPacket
    {
        public AuthKeyLoginRequest(string authenticationKey)
        {
            AuthenticationKey = authenticationKey;
        }

        public string AuthenticationKey { get; set; }
    }
}
