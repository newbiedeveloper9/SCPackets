namespace SCPackets.Packets.CreateRoom
{
    public enum CreateRoomResult
    {
        Success,
        AlreadyExist,
        Error,
        NameError,
        ImageError,
        LocalMessageError,
        PublicMessageError,
    }
}
