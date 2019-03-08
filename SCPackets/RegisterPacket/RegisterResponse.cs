using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.RegisterPacket
{
    [PacketRequest(typeof(RegisterRequest))]
    public class RegisterResponse : ResponsePacket
    {
        public RegisterResponse(Result result, RegisterRequest packet)
            : base(packet)
        {
            ResultTmp = (int)result;
        }

        public int ResultTmp { get; set; }

        [PacketIgnoreProperty]
        public Result Result => (Result) ResultTmp;
    }
}
