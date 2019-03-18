using Network.Attributes;
using Network.Packets;
using SCPackets.CreateRoom.Container;

namespace SCPackets.UpdateRoomData
{
    [PacketRequest(typeof(UpdateRoomDataRequest))]
    public class UpdateRoomDataResponse : ResponsePacket
    {
        public UpdateRoomDataResponse(Result result, UpdateRoomDataRequest request)
            : base(request)
        {
            Result = result;
        }
        public Result Result { get; set; }
        public RoomModel Room { get; set; } = new RoomModel();
    }
}
