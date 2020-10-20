using Network.Attributes;
using SharpDj.Common.Enums;

namespace SCPackets.Models
{
    public class UserClient
    {
        public UserClient()
        {

        }

        public UserClient(long id, string username, Rank rank)
        {
            Id = id;
            Username = username;
            Rank = rank;
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public Rank Rank { get; set; }

        public bool Equals(UserClient other)
        {
            return Id == other.Id && string.Equals(Username, other.Username) && Rank == other.Rank;
        }
    }
}
