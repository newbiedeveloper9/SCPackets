using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using Network.Interfaces;

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

        public void RegisterPacket(Connection conn)
        {
            conn.RegisterStaticPacketHandler(_packetHandler);
        }
        public void RegisterPacket(Connection conn, IClient client)
        {
            conn.RegisterPacketHandler(_packetHandler, client);
        }

        private void Handler(TReq packet, Connection connection)
        {
            //TODO: add logging
            Action?.Invoke(packet, connection);
            Console.WriteLine($"packet handle {packet}");
        }
    }
}
