using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace SCPackets.ConnectToRoom
{
    public class ConnectToRoomRequest :RequestPacket
    {
        public ConnectToRoomRequest(int roomId)
        {
            RoomId = roomId;
        }

        public int RoomId { get; set; }
    }
}
