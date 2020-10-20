using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Packets.CreateRoomMessage
{
    public class CreateRoomMessageRequest : RequestPacket
    {
        public CreateRoomMessageRequest(Color color, string message)
        {
            Post.Color = color;
            Post.Message = message;
        }

        public ChatMessage Post { get; set; } = new ChatMessage();
    }
}
