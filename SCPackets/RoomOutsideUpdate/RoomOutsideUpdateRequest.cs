using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.RoomOutsideUpdate
{
    public class RoomOutsideUpdateRequest : RequestPacket
    {
        public RoomOutsideUpdateRequest(RoomOutsideModel roomOutsideModel)
        {
            RoomOutsideModel = roomOutsideModel;
        }

        public RoomOutsideModel RoomOutsideModel { get; set; }
    }
}
