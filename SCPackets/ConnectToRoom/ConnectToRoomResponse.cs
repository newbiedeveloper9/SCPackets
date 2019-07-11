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
        public ConnectToRoomResponse(Result result, RoomOutsideModel roomOutsideModel, RequestPacket packet) : base(packet)
        {
            Result = result;
            RoomOutsideModel = roomOutsideModel;
        }

        public ConnectToRoomResponse(Result result, RequestPacket packet) : base(packet)
        {
            Result = result;
            RoomOutsideModel = null;
        }

        public Result Result { get; set; }
        public RoomOutsideModel RoomOutsideModel { get; set; }
    }
}
