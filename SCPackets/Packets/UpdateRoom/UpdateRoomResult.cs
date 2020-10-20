namespace SCPackets.Packets.UpdateRoom
{
    public enum UpdateRoomResult
    {
        Success,
        AlreadyExist,
        NameError,
        ImageError,
        LocalMessageError,
        PublicMessageError,

        Error
    }
}