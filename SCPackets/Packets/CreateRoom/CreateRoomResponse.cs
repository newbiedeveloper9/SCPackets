using Network.Attributes;
using Network.Packets;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.CreateRoom
{
    [PacketRequest(typeof(CreateRoomRequest))]

    public class CreateRoomResponse : ResponsePacket
    {
        public CreateRoomResponse(CreateRoomResult result, CreateRoomRequest req)
            : base(req)
        {
            Result = result;
        }

        public RoomDetailsDTO RoomDetails { get; set; } = new RoomDetailsDTO();

        public CreateRoomResult Result { get; set; }
    }
}
