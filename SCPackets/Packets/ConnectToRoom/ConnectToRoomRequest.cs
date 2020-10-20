using Network.Packets;

namespace SCPackets.Packets.ConnectToRoom
{
    public class ConnectToRoomRequest :RequestPacket
    {
        public ConnectToRoomRequest(int roomId)
        {
            RoomId = roomId;
        }

        public int RoomId { get; set; }
    }
}
