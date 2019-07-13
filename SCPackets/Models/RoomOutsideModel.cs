using Network.Attributes;

namespace SCPackets.Models
{
    public class RoomOutsideModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int AmountOfPeople { get; set; }
        public int AmountOfAdministration { get; set; }

        public TrackModel NextTrack { get; set; } = new TrackModel();
        public TrackModel CurrentTrack { get; set; } = new TrackModel();
        public TrackModel PreviousTrack { get; set; } = new TrackModel();
    }
}
