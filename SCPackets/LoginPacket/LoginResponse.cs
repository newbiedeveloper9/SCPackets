using System.CodeDom;
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
            ResultInt = (int)result;
        }
       
        public int ResultInt { get; set; }

        [PacketIgnoreProperty]
        public Result Result => (Result) ResultInt;
    }
}
