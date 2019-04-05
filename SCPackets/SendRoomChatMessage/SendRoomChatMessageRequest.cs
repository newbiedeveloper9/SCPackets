using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace SCPackets.SendRoomChatMessage
{
    class SendRoomChatMessageRequest : RequestPacket
    {
        public SendRoomChatMessageRequest(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }
}
