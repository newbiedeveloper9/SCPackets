using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.SendRoomChatMessage
{
    [PacketRequest(typeof(SendRoomChatMessageRequest))]
    class SendRoomChatMessageResponse : ResponsePacket
    {
        public SendRoomChatMessageResponse(Result result, SendRoomChatMessageRequest request) 
            : base(request)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}
