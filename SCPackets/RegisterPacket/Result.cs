namespace SCPackets.RegisterPacket
{
    public enum Result
    {
        Success, 
        AlreadyExist,
        EmailError,
        LoginError,
        UsernameError,
        PasswordError,
        Error,
    }
}