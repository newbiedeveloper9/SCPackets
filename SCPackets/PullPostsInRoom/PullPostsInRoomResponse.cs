using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.PullPostsInRoom
{
    [PacketRequest(typeof(PullPostsInRoomRequest))]
    public class PullPostsInRoomResponse : RequestPacket
    {
        public PullPostsInRoomResponse(Result result)
        {
            Result = result;
        }

        public List<RoomPostModel> Posts { get; set; } = new List<RoomPostModel>();
        public Result Result { get; set; }
    }
}
