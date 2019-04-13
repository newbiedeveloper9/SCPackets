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
        public SendRoomChatMessageRequest(string message, ColorModel color)
        {
            Color = color;
            Message = message;
        }

        public ColorModel Color { get; set; }
        public string Message { get; set; }
    }
}
