using Network.Attributes;

namespace SCPackets
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
            RankTmp = (int)rank;
        }

        public long Id { get; set; }
        public string Username { get; set; }

        [PacketIgnoreProperty]
        public Rank Rank => (Rank)RankTmp;
        public int RankTmp { get; set; }

        protected bool Equals(UserClient other)
        {
            return Id == other.Id && string.Equals(Username, other.Username) && Rank == other.Rank;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (Username != null ? Username.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)Rank;
                return hashCode;
            }
        }
    }
}
