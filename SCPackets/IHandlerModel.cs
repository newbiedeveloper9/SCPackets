using Network;

namespace SCPackets
{
    public interface IHandlerModel
    {
        void RegisterPacket(Connection conn, IClient client);
        void RegisterPacket(Connection conn);
    }
}