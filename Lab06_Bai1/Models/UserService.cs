namespace Lab06_Bai1.Models
{
    public class UserService : IUserService
    {
        private static readonly List<string> _users = new();
        public void AddUser(string user)
        {
            _users.Add(user);
        }
        public List<string> GetUsers()
        {
            return _users;
        }
    }
}
