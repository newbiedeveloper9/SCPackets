using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.NewRoomCreated
{
    public class NewRoomCreatedRequest : RequestPacket
    {
        public NewRoomCreatedRequest(RoomOutsideModel room)
        {
            Room = room;
        }

        public RoomOutsideModel Room { get; set; }
    }
}
