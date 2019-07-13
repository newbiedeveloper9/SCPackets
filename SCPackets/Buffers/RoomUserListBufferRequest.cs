using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Buffers
{
    public class RoomUserListBufferRequest :RequestPacket
    {
        public int RoomId { get; set; }
        public List<UserClientModel> InsertUserList { get; set; } = new List<UserClientModel>();
        public List<UserClientModel> RemoveUserList { get; set; } = new List<UserClientModel>();
        public List<UserClientModel> UpdateUserList { get; set; } = new List<UserClientModel>();

        public RoomUserListBufferRequest(int roomId)
        {
            RoomId = roomId;
        }
    }
}
