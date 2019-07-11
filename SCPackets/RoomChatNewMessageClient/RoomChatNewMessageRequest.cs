using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;
using SCPackets.SendRoomChatMessage;

namespace SCPackets.RoomChatNewMessageClient
{
    public class RoomChatNewMessageRequest : SendRoomChatMessageRequest
    {
        public RoomChatNewMessageRequest(ColorModel color, string message, int roomId, UserClientModel author)
            : base(color, message, roomId)
        {
            Author = author;
        }

        public RoomChatNewMessageRequest(SendRoomChatMessageRequest request, UserClientModel author)
            : base(request.Color, request.Message, request.RoomId)
        {
            Author = author;
        }

        public UserClientModel Author { get; set; }
    }
}
