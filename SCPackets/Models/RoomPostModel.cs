using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPackets.Models
{
    public class RoomPostModel
    {
        public UserClientModel Author { get; set; }
        public ColorModel Color { get; set; }
        public string Message { get; set; }
    }
}
