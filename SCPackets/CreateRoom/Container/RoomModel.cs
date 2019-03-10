﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPackets.CreateRoom.Container
{
    public class RoomModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string LocalEnterMessage { get; set; }
        public string LocalLeaveMessage { get; set; }
        public string PublicEnterMessage { get; set; }
        public string PublicLeaveMessage { get; set; }
    }
}
