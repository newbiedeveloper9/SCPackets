using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.SendRoomChatMessage
{
    public class SendRoomChatMessageRequest : RequestPacket
    {
        public SendRoomChatMessageRequest(ColorModel color, string message)
        {
            Post.Color = color;
            Post.Message = message;
        }

        public RoomPostModel Post { get; set; } = new RoomPostModel();
    }
}
