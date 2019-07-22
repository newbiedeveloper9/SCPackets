using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.PullPostsInRoom
{
    public class PullPostsInRoomResponse : RequestPacket
    {
        public PullPostsInRoomResponse(Result result, PullPostsInRoomRequest packet)
        {
            Result = result;
        }

        public List<RoomPostModel> Posts { get; set; } = new List<RoomPostModel>();
        public Result Result { get; set; }
    }
}
