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
            ResultTmp = (int)result;
        }

        public List<RoomOutsideModel> RoomOutsideModelList { get; set; } = new List<RoomOutsideModel>();
        public List<RoomModel> UserRoomList { get; set; } = new List<RoomModel>();
        public UserClient User { get; set; } = new UserClient();

        public int ResultTmp { get; set; }

        [PacketIgnoreProperty]
        public Result Result => (Result) ResultTmp;
    }
}
