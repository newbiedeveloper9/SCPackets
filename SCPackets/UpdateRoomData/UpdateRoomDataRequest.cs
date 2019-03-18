using Network.Attributes;
using Network.Packets;
using SCPackets.CreateRoom.Container;

namespace SCPackets.UpdateRoomData
{
    public class UpdateRoomDataRequest : RequestPacket
    {
        public UpdateRoomDataRequest(RoomModel room)
        {
            Room = room;
        }

        public RoomModel Room { get; set; }
    }
}
