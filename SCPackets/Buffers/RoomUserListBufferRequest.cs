using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Buffers
{
    public class RoomUserListBufferRequest : RequestPacket
    {
        public int RoomId { get; set; }
        public ListWrapper<UserClientModel> InsertUsers { get; set; } = new ListWrapper<UserClientModel>();
        public ListWrapper<UserClientModel> RemoveUsers { get; set; } = new ListWrapper<UserClientModel>();

        public List<UserClientModel> UpdateUsers { get; set; } = new List<UserClientModel>();

        public RoomUserListBufferRequest(int roomId)
        {
            RoomId = roomId;

            //Clean other list
            InsertUsers.AfterAdd += (sender, e) => RemoveUsers.Remove(e.Item);
            RemoveUsers.AfterAdd += (sender, e) => InsertUsers.Remove(e.Item);
        }
    }
}
