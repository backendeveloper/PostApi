namespace Common
{
    public interface IUserContext
    {
        string CurrentUserEmail { get; }

        string CurrentUserFullName { get; }
    }
}