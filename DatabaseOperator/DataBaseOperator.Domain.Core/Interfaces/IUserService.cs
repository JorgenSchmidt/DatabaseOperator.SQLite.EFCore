namespace DataBaseOperator.Domain.Core.Interfaces
{
    public interface IUserService
    {
        List<User> AddUser(string _firstname, string _secondname);
        List<User> UpdateUser(string _id, string _firstname, string _secondname, int _balance);
        List<User> DeleteUser(string _id);
        List<User> GetUserDataBase();


        List<User> SearchUserByID(string _id);
        List<User> SearchUserByFirstName(string _firstname);
        List<User> SearchUserBySecondName(string _secondname);
        List<User> SearchUserByBalance(int _sincebalance, int _untilbalance);
    }
}
