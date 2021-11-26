using DataBaseOperator.DAL.Data.SQLite.Services;
using DataBaseOperator.Domain.Core;
using DataBaseOperator.Domain.Core.Interfaces;

namespace DataBaseOperator.DAL.Data.SQLite.UserDAL
{
    public class UserDbRepository : IUserService
    {

        #region CRUD operations

        // For add target object in data base
        List<User> IUserService.AddUser(string _firstname, string _secondname)
        {
            using var db = new UserDbContext();

            var newobj = new User
            {
                ID = DbMethods.GetFreeIDFromUserList(db.Users.ToList()).ToString(),
                FirstName = _firstname,
                SecondName = _secondname,
                Balance = 0
            };

            db.Users.Add(newobj);
            db.SaveChanges();

            return db.Users.ToList();
        }

        // For update information about object
        List<User> IUserService.UpdateUser(string _id, string _firstname, string _secondname, int _balance)
        {
            using var db = new UserDbContext();

            foreach (var curUser in db.Users.ToList())
            {
                if (_id.Equals(curUser.ID))
                {
                    if (!String.IsNullOrEmpty(_firstname))  curUser.FirstName = _firstname;
                    if (!String.IsNullOrEmpty(_secondname)) curUser.SecondName = _secondname;
                    curUser.Balance += _balance;
                    db.Users.Update(curUser);
                    break;
                }
            }

            db.SaveChanges();

            return db.Users.ToList();
        }

        // For delete object from data base
        List<User> IUserService.DeleteUser(string _id)
        {
            using var db = new UserDbContext();

            foreach(var curUser in db.Users.ToList())
            {
                if (_id.Equals(curUser.ID))
                {
                    db.Users.Remove(curUser);
                    break;
                }
            }

            db.SaveChanges();

            return db.Users.ToList();
        }

        // For get target database
        List<User> IUserService.GetUserDataBase()
        {
            using var db = new UserDbContext();

            return db.Users.ToList();
        }

        #endregion

        #region Search operations


        List<User> IUserService.SearchUserByID(string _id)
        {
            using var db = new UserDbContext();
            List<User> userList = new();

            foreach (var curUser in db.Users.ToList())
            {
                if(_id.Equals(curUser.ID))
                {
                    userList.Add(curUser);
                    break;
                }
            }

            return userList;
        }

        List<User> IUserService.SearchUserByFirstName(string _firstname)
        {
            using var db = new UserDbContext();
            List<User> userList = new();

            foreach (var curUser in db.Users.ToList())
            {
                if (!String.IsNullOrEmpty(curUser.FirstName))
                {
                    if (DbMethods.SearchMatchesInTheInput(curUser.FirstName, _firstname))
                    {
                        userList.Add(curUser);
                    }
                }
            }

            return userList;
        }

        List<User> IUserService.SearchUserBySecondName(string _secondname)
        {
            using var db = new UserDbContext();
            List<User> userList = new();

            foreach (var curUser in db.Users.ToList())
            {
                if (!String.IsNullOrEmpty(curUser.SecondName))
                {
                    if (DbMethods.SearchMatchesInTheInput(curUser.SecondName, _secondname))
                    {
                        userList.Add(curUser);
                    }
                }
            }

            return userList;
        }

        List<User> IUserService.SearchUserByBalance(int _sincebalance, int _untilbalance)
        {
            using var db = new UserDbContext();
            List<User> userList = new();

            foreach (var curUser in db.Users.ToList())
            {
                if (curUser.Balance >= _sincebalance && curUser.Balance <= _untilbalance)
                {
                    userList.Add(curUser);
                }
            }

            return userList;
        }

        #endregion

    }
}