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
        public long Id { get; set; }
    }
}
