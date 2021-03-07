using System.Collections.Generic;
using Network.Packets;
using SharpDj.Common;
using SharpDj.Common.DTO;
using SharpDj.Common.ListWrapper;

namespace SCPackets.Packets.Buffers
{
    public class SquareRoomBufferRequest : RequestPacket
    {
        public ListWrapper<PreviewRoomDTO> InsertRooms { get; set; } = new ListWrapper<PreviewRoomDTO>();
        public ListWrapper<PreviewRoomDTO> RemoveRooms { get; set; } = new ListWrapper<PreviewRoomDTO>();
        public List<PreviewRoomDTO> UpdatedRooms { get; set; } = new List<PreviewRoomDTO>();

        public SquareRoomBufferRequest()
        {
            
        }
    }
}
