using Network.Attributes;
using Network.Packets;

namespace SCPackets.Packets.CreateRoomMessage
{
    [PacketRequest(typeof(CreateRoomMessageRequest))]

    public class CreateRoomMessageResponse : ResponsePacket
    {
        public CreateRoomMessageResponse(CreateRoomMessageResult result, RequestPacket request)
            : base(request)
        {
            Result = result;
        }

        public CreateRoomMessageResult Result { get; set; }
    }
}
