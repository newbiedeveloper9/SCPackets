using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;

namespace SCPackets.AuthKeyLogin
{
    [PacketRequest(typeof(AuthKeyLoginRequest))]
    public class AuthKeyLoginResponse : ResponsePacket
    {
        public AuthKeyLoginResponse(Result result ,AuthKeyLoginRequest packet) : base(packet)
        {
            Result = result;
        }

        public Result Result { get; set; }

        public LoginDataModel Data { get; set; } = new LoginDataModel();
    } 
}
