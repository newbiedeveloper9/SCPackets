using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.ConnectToRoom
{
    [PacketRequest(typeof(ConnectToRoomRequest))]
    public class ConnectToRoomResponse : ResponsePacket
    {
        public ConnectToRoomResponse(Result result, RequestPacket packet) : base(packet)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}
