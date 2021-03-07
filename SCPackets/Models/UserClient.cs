namespace SCPackets.Models
{
    public class UserClient
    {
        public UserClient()
        {

        }

        public UserClient(long id, string username)
        {
            Id = id;
            Username = username;
        }

        public long Id { get; set; }
        public string Username { get; set; }

        public bool Equals(UserClient other)
        {
            return Id == other.Id && string.Equals(Username, other.Username);
        }
    }
}
