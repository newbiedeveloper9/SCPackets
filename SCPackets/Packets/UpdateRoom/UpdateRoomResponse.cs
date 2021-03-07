using Network.Attributes;
using Network.Packets;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.UpdateRoom
{
    [PacketRequest(typeof(UpdateRoomRequest))]
    public class UpdateRoomResponse : ResponsePacket
    {

        public UpdateRoomResponse(UpdateRoomResult result, RoomDetailsDTO roomDetails, UpdateRoomRequest packet)
            : base(packet)
        {
            RoomDetails = roomDetails;
            Result = result;
        }

        public UpdateRoomResponse(UpdateRoomResult result, UpdateRoomRequest packet)
            : base(packet)
        {
            Result = result;
        }

        public UpdateRoomResult Result { get; set; }
        public RoomDetailsDTO RoomDetails { get; set; } = new RoomDetailsDTO();
    }
}
