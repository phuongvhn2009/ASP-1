namespace Lab06_Bai1.Models
{
    public interface IUserService
    {
        List<string> GetUsers();
        void AddUser(string user);
    }
}
