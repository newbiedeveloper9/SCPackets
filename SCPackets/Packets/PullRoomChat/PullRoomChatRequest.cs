using Network.Packets;

namespace SCPackets.Packets.PullRoomChat
{
    public class PullRoomChatRequest : RequestPacket
    {
        public int RoomId { get; set; }
        public int MessageCount { get; set; }

        public PullRoomChatRequest(int roomId, int messageCount)
        {
            RoomId = roomId;
            MessageCount = messageCount;
        }
    }
}
