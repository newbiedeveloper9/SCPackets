using Network.Packets;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.UpdateRoom
{
    public class UpdateRoomRequest : RequestPacket
    {
        public UpdateRoomRequest(RoomDetailsDTO roomDetails)
        {
            RoomDetails = roomDetails;
        }

        public RoomDetailsDTO RoomDetails { get; set; }
    }
}
