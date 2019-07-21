using System.CodeDom;
using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.CreateRoom.Container;
using SCPackets.Models;
using Result = SCPackets.LoginPacket.Container.Result;

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

        public LoginDataModel Data { get; set; } = new LoginDataModel();

        public Result Result { get; set; }
        public string AuthenticationKey { get; set; }
    }
}
