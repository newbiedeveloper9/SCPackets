﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace SCPackets.LoginPacket
{
    public class LoginRequest : RequestPacket
    {
        public LoginRequest(string login, string password, bool rememberMe = false)
        {
            Login = login;
            Password = password;
            RememberMe = rememberMe;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
