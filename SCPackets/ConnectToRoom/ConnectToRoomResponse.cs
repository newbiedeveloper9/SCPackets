using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Attributes;
using Network.Packets;
using SCPackets.CreateRoom.Container;
using SCPackets.Models;

namespace SCPackets.ConnectToRoom
{
    [PacketRequest(typeof(ConnectToRoomRequest))]
    public class ConnectToRoomResponse : ResponsePacket
    {
        public ConnectToRoomResponse(Result result, RoomOutsideModel roomOutsideModel, List<UserClientModel> userList, RequestPacket packet) : base(packet)
        {
            Result = result;
            RoomOutsideModel = roomOutsideModel;
            UserList = userList;
        }

        public ConnectToRoomResponse(Result result, RequestPacket packet) : base(packet)
        {
            Result = result;
            RoomOutsideModel = new RoomOutsideModel();
            UserList = new List<UserClientModel>();
        }

        public Result Result { get; set; }
        public RoomOutsideModel RoomOutsideModel { get; set; }
        public List<UserClientModel> UserList { get; set; }
    }
}
