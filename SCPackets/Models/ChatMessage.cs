using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPackets.Models
{
    public class ChatMessage
    {
        public ChatMessage()
        {
            Author = new UserClient();
        }
        public UserClient Author { get; set; }
        public Color Color { get; set; }
        public string Message { get; set; }
        public int Id { get; set; }
    }
}
