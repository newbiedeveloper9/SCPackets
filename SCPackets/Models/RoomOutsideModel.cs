using Network.Attributes;

namespace SCPackets.Models
{
    public class RoomOutsideModel
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int AmountOfPeople { get; set; }
        public int AmountOfAdministration { get; set; }

        public TrackModel NextTrack { get; set; }
        public TrackModel CurrentTrack { get; set; }
        public TrackModel PreviousTrack { get; set; }
    }
}
