using System.CodeDom;
using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.LoginPacket.Container;
using SCPackets.Models;

namespace SCPackets.LoginPacket
{
    [PacketRequest(typeof(LoginRequest))]
    public class LoginResponse : ResponsePacket
    {
        public LoginResponse(Result result, LoginRequest request)
            : base(request)
        {
            ResultTmp = (int)result;
            
        }

        public List<RoomOutsideModel> RoomOutsideModelList { get; set; }
        public UserClient User { get; set; }

        public int ResultTmp { get; set; }

        [PacketIgnoreProperty]
        public Result Result => (Result) ResultTmp;
    }
}
