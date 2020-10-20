using Network.Packets;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.CreateRoom
{
    public class CreateRoomRequest : RequestPacket
    {
        public CreateRoomRequest(RoomDetailsDTO roomDetailsModel)
        {
            RoomDetailsModel = roomDetailsModel;
        }

        public RoomDetailsDTO RoomDetailsModel { get; set; }
    }
}
