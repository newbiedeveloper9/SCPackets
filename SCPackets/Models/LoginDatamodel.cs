using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCPackets.CreateRoom.Container;

namespace SCPackets.Models
{
    public class LoginDataModel
    {
        public List<RoomOutsideModel> RoomOutsideModelList { get; set; } = new List<RoomOutsideModel>();
        public List<RoomModel> UserRoomList { get; set; } = new List<RoomModel>();
        public UserClientModel User { get; set; } = new UserClientModel();
    }
}
