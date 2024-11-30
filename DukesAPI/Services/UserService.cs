namespace DukesAPI.Services
{
    public class UserService : IUserService
    {
        public bool IsValidUserCredentials(string username, string password)
        {
            //TODO: Change this to external auth
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
