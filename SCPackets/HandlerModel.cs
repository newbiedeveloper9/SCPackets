using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Network;
using Network.Interfaces;
using Network.Packets;

namespace SCPackets
{
    public class HandlerModel<TReq> where TReq : Packet
    {
        /// <summary>
        /// If Action != null then invoke
        /// </summary>
        public Action<TReq, Connection> Action { get; set; }
        private readonly PacketReceivedHandler<TReq> _packetHandler;
        

        public HandlerModel()
        {
            _packetHandler = Handler;
        }



        public void RegisterPacket(Connection conn, bool loginRequired = false)
        {
            conn.RegisterStaticPacketHandler(_packetHandler);
        }
        public void RegisterPacket(Connection conn, IClient client)
        {
            conn.RegisterPacketHandler(_packetHandler, client);
        }

        private void Handler(TReq packet, Connection connection)
        {
            Action?.Invoke(packet, connection);
            Console.WriteLine($"packet handle {packet}");
        }
    }
}
