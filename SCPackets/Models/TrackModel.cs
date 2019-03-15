using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPackets.Models
{
    public class TrackModel
    {
        public string ImageUrl { get; set; } = "";
        public string TrackUrl { get; set; } = "";
        public int Duration { get; set; }
        public string Author { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
