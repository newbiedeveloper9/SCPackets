using Network.Attributes;
using Network.Packets;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.UpdateRoom
{
    [PacketRequest(typeof(UpdateRoomRequest))]
    public class UpdateRoomResponse : ResponsePacket
    {
        public UpdateRoomResponse(UpdateRoomResult result, UpdateRoomRequest request)
            : base(request)
        {
            Result = result;
        }
        public UpdateRoomResult Result { get; set; }
        public RoomDetailsDTO RoomDetails { get; set; } = new RoomDetailsDTO();
    }
}
