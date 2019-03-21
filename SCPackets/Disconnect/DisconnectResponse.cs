using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.Disconnect
{
    [PacketRequest(typeof(DisconnectRequest))]
    public class DisconnectResponse : ResponsePacket
    {
        public DisconnectResponse(Result result, DisconnectRequest packet) : base(packet)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}
