using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.Buffers
{
    public class SquareRoomBufferRequest : RequestPacket
    {
        public ListWrapper<RoomOutsideModel> InsertRooms { get; set; } = new ListWrapper<RoomOutsideModel>();
        public ListWrapper<RoomOutsideModel> RemoveRooms { get; set; } = new ListWrapper<RoomOutsideModel>();
        public List<RoomOutsideModel> UpdatedRooms { get; set; } = new List<RoomOutsideModel>();

        public SquareRoomBufferRequest()
        {
            
        }
    }
}
