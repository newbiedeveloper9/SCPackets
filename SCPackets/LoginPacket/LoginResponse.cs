using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;

namespace SCPackets.LoginPacket
{
    [PacketRequest(typeof(LoginRequest))]
    public class LoginResponse : ResponsePacket
    {
        public LoginResponse(Result result, LoginRequest request)
            : base(request)
        {
            Result = result;
        }

        public Result Result { get; set; }
    }
}
