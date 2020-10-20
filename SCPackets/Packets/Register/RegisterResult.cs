namespace SCPackets.Packets.Register
{
    public enum RegisterResult
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