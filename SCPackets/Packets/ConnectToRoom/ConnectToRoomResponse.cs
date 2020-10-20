using System.Collections.Generic;
using Network.Attributes;
using Network.Packets;
using SCPackets.Models;
using SharpDj.Common.DTO;

namespace SCPackets.Packets.ConnectToRoom
{
    [PacketRequest(typeof(ConnectToRoomRequest))]
    public class ConnectToRoomResponse : ResponsePacket
    {
        public ConnectToRoomResponse(ConnectToRoomResult result, PreviewRoomDTO previewRoom, List<UserClient> userList, RequestPacket packet) : base(packet)
        {
            Result = result;
            PreviewRoom = previewRoom;
            UserList = userList;
        }

        public ConnectToRoomResponse(ConnectToRoomResult result, RequestPacket packet) : base(packet)
        {
            Result = result;
            PreviewRoom = new PreviewRoomDTO();
            UserList = new List<UserClient>();
        }

        public ConnectToRoomResult Result { get; set; }
        public PreviewRoomDTO PreviewRoom { get; set; }
        public List<UserClient> UserList { get; set; }
    }
}
