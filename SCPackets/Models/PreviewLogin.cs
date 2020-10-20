using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDj.Common.DTO;

namespace SCPackets.Models
{
    public class PreviewLogin
    {
        public List<PreviewRoomDTO> RoomOutsideModelList { get; set; } = new List<PreviewRoomDTO>();
        public List<RoomDetailsDTO> UserRoomList { get; set; } = new List<RoomDetailsDTO>();
        public UserClient User { get; set; } = new UserClient();
    }
}
