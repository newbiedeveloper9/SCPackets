using Network.Attributes;
using Network.Packets;

namespace SCPackets.Packets.Register
{
    [PacketRequest(typeof(RegisterRequest))]
    public class RegisterResponse : ResponsePacket
    {
        public RegisterResponse(RegisterResult result, RegisterRequest packet)
            : base(packet)
        {
            Result = Result;
        }

        public RegisterResult Result { get; set; }

        
    }
}
