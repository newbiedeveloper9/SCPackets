using Network.Attributes;
using Network.Packets;

namespace SCPackets.Packets.Disconnect
{
    [PacketRequest(typeof(DisconnectRequest))]
    public class DisconnectResponse : ResponsePacket
    {
        public DisconnectResponse(DisconnectResult result, DisconnectRequest packet) : base(packet)
        {
            Result = result;
        }

        public DisconnectResult Result { get; set; }
    }
}
