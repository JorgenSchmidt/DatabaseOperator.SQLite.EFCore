using System;
using System.Collections.Generic;

using DataBaseOperator.Domain.Core;

namespace DataBaseOperator.DAL.Data.SQLite.Services
{
    public class DbMethods 
    {
        // this methods try to give the smallest and not included in the DataBase ID value which must be more than zero
        public static int GetFreeIDFromUserList(List<User> _gettedList)
        {

            List<int> idlist = new();

            foreach (var curUser in _gettedList)
            {
                idlist.Add(Convert.ToInt32(curUser.ID));
            }

            idlist.Sort();

            int currentID = 0;
            foreach (var curUser in idlist)
            {
                currentID += 1;
                if (curUser <= 0) { currentID = 0; }
                if (currentID != curUser && curUser > 0) return currentID;
            }
            return currentID + 1;
        }

        public static int GetFreeIDFromProdList(List<Product> _gettedList)
        {

            List<int> idlist = new();

            foreach (var curUser in _gettedList)
            {
                idlist.Add(Convert.ToInt32(curUser.ID));
            }

            idlist.Sort();

            int currentID = 0;
            foreach (var curUser in idlist)
            {
                currentID += 1;
                if (curUser <= 0) { currentID = 0; }
                if (currentID != curUser && curUser > 0) return currentID;
            }
            return currentID + 1;
        }

        // for search matches in the input 
        // target string is a string which we have to compare with compared string
        public static bool SearchMatchesInTheInput(string _targetString, string _comparedString)
        {
            var count = 0;
            if (_targetString.Length < _comparedString.Length) return false;
            foreach (var curLetter in _comparedString)
            {
                if (!curLetter.Equals(_targetString[count]))
                {
                    return false;
                }
                count++;
            }
            return true;
        }

        // for determining whether a string is a number
        public static bool IsAIntNumber(string _input)
        {
            if (String.IsNullOrEmpty(_input)) return false;

            foreach (char curSym in _input)
            {
                if (!Char.IsDigit(curSym)) return false;
            }

            return true;
        }

    }
}
