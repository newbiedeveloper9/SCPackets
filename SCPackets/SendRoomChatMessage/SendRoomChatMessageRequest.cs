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
        public SendRoomChatMessageRequest(ColorModel color, string message, int roomId)
        {
            Color = color;
            Message = message;
            RoomId = roomId;
        }

        public ColorModel Color { get; set; }
        public string Message { get; set; }
        public int RoomId { get; set; }
    }
}
