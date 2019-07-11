using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.SendRoomChatMessage
{
    public class SendRoomChatMessageResponse : RequestPacket
    {
        public SendRoomChatMessageResponse(Result result)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}
