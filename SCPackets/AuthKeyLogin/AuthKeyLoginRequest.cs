using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace SCPackets.AuthKeyLogin
{
    public class AuthKeyLoginRequest : RequestPacket
    {
        public AuthKeyLoginRequest(string authenticationKey)
        {
            AuthenticationKey = authenticationKey;
        }

        public string AuthenticationKey { get; set; }
    }
}
