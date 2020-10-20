using Network.Packets;

namespace SCPackets.Packets.CreateRoomMessage
{
    public class CreateRoomMessageResponse : RequestPacket
    {
        public CreateRoomMessageResponse(CreateRoomMessageResult result)
        {
            Result = result;
        }

        public CreateRoomMessageResult Result { get; set; }
    }
}
