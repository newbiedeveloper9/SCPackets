using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace SCPackets.RegisterPacket
{
    public class RegisterRequest : RequestPacket
    {
        public RegisterRequest(string login, string password, string email, string username)
        {
            Login = login;
            Password = password;
            Email = email;
            Username = username;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
