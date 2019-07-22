using Network.Packets;

namespace SCPackets.PullPostsInRoom
{
    public class PullPostsInRoomRequest : RequestPacket
    {
        public PullPostsInRoomRequest(int roomId, int messageCount)
        {
            RoomId = roomId;
            MessageCount = messageCount;
        }

        public int RoomId { get; set; }
        public int MessageCount { get; set; }
    }
}
