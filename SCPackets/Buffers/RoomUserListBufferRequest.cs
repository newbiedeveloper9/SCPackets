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
        public List<UserClientModel> InsertUserList { get; set; } = new List<UserClientModel>();
        public List<UserClientModel> RemoveUserList { get; set; } = new List<UserClientModel>();

        public List<UserClientModel> UpdateUserList { get; set; } = new List<UserClientModel>();

        public RoomUserListBufferRequest(int roomId)
        {
            RoomId = roomId;

            //Remove object from another list if exist

        }

        public void AddUser(UserClientModel user)
        {
            RemoveUserList.Remove(user);

            //Only one instance will exist
            if (InsertUserList.Count(x => x.Id == user.Id) == 0)
                InsertUserList.Add(user);
        }

        public void RemoveUser(UserClientModel user)
        {
            InsertUserList.Remove(user);

            //Only one instance will exist
            if (RemoveUserList.Count(x => x.Id == user.Id) == 0)
                RemoveUserList.Add(user);
        }
    }
}
