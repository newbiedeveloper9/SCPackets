using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.CreateRoom.Container;

namespace SCPackets.CreateRoom
{
    public class CreateRoomRequest : RequestPacket
    {
        public CreateRoomRequest(RoomModel roomModel)
        {
            RoomModel = roomModel;
        }

        public RoomModel RoomModel { get; set; }
    }
}
