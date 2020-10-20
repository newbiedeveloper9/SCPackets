using Network.Packets;

namespace SCPackets.Packets.Register
{
    public class RegisterRequest : RequestPacket
    {
        public RegisterRequest(string login, string password, string email, string username)
        {
            Login = login;
            Password = password;
            Email = email;
            Username = username;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
