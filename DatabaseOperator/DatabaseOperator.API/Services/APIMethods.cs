using System.Collections.Generic;

using DataBaseOperator.DAL.Data.SQLite.UserDAL;
using DataBaseOperator.Domain.Core;

namespace DatabaseOperator.API.Services
{
    public class APIMethods
    {

        // for concat in one list all matching elements in list
        public static List<User> ConcatUserListsAND (List<User> _first, List<User> _second)
        {

            List<User> userList = new();

            foreach(var curFirst in _first)
            {
                foreach (var curSecond in _second)
                {
                    if (curFirst.ID.Equals(curSecond.ID))
                    {
                        userList.Add(curFirst);
                    }
                }
            }

            return userList;
        }

    }
}