using SCPackets.Models;
using SCPackets.Packets.CreateRoomMessage;

namespace SCPackets.Packets.RoomNewMessageRequest
{
    public class RoomNewMessageRequest : CreateRoomMessageRequest
    {
        public RoomNewMessageRequest(Color color, string message, int roomId, UserClient author)
            : base(color, message)
        {
            Post.Author = author;
        }

        public RoomNewMessageRequest(CreateRoomMessageRequest request, UserClient author)
            : base(request.Post.Color, request.Post.Message)
        {
            Post.Author = author;
        }
    }
}
