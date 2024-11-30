namespace DukesAPI.Services
{
    public interface IUserService
    {
        bool IsValidUserCredentials(string username, string password);
    }
}
