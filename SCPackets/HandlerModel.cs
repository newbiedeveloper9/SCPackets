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
    public class HandlerModel<TReq> : IHandlerModel where TReq : Packet
    {
        /// <summary>
        /// If Action != null then invoke
        /// </summary>
        public Action<TReq, Connection> Action { get; set; }
        private readonly PacketReceivedHandler<TReq> _packetHandler;

        public HandlerModel(Action<TReq, Connection> action)
        {
            _packetHandler = Handler;
            Action = action;
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
            Task.Factory.StartNew(() => Action.Invoke(packet, connection));
            //Action.Invoke(packet, connection);
        }
    }
}
