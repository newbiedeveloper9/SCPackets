using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Packets.PullRoomChat
{
    [PacketRequest(typeof(PullRoomChatRequest))]
    public class PullRoomChatResponse : RequestPacket
    {
        public PullRoomChatResponse(PullRoomChatResult result)
        {
            Result = result;
        }

        public List<ChatMessage> Posts { get; set; } = new List<ChatMessage>();
        public PullRoomChatResult Result { get; set; }
    }
}
