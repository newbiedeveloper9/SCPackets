using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;
using SCPackets.CreateRoom.Container;
using SCPackets.LoginPacket;
using Result = SCPackets.CreateRoom.Container.Result;

namespace SCPackets.CreateRoom
{
    [PacketRequest(typeof(CreateRoomRequest))]

    public class CreateRoomResponse : ResponsePacket
    {
        public CreateRoomResponse(Result result, CreateRoomRequest req)
            : base(req)
        {
            ResultTmp = (int)result;
        }

        public RoomModel Room { get; set; } = new RoomModel();
        public int ResultTmp { get; set; }

        [PacketIgnoreProperty] public Result Result => (Result) ResultTmp;
    }
}
