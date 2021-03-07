using System.Collections.Generic;
using Network.Packets;
using SCPackets.Models;
using SharpDj.Common;
using SharpDj.Common.ListWrapper;

namespace SCPackets.Packets.Buffers
{
    public class RoomUserListBufferRequest : RequestPacket
    {
        public int RoomId { get; set; }
        public ListWrapper<UserClient> InsertUsers { get; set; } = new ListWrapper<UserClient>();
        public ListWrapper<UserClient> RemoveUsers { get; set; } = new ListWrapper<UserClient>();

        public List<UserClient> UpdateUsers { get; set; } = new List<UserClient>();

        public RoomUserListBufferRequest(int roomId)
        {
            RoomId = roomId;
            
            InsertUsers.AfterAdd += (sender, e) => RemoveUsers.Remove(e.Item);
            RemoveUsers.AfterAdd += (sender, e) => InsertUsers.Remove(e.Item);
        }
    }
}
