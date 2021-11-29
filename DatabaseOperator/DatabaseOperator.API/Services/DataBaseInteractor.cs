using System.Collections.Generic;

using DataBaseOperator.DAL.Data.SQLite.ProductDAL;
using DataBaseOperator.DAL.Data.SQLite.UserDAL;
using DataBaseOperator.Domain.Core;

namespace DatabaseOperator.API.Services
{
    // for interaction with data base repositories via (!) buttons
    // this class is go-between buttons and repositories
    // interaction with user dal and product dal is XOR (mutually exclusive)
    public class DataBaseInteractor
    {

        #region for CRUD operations

        // for add objects to data base
        public static List<User> AddUser(string _firstname, string _secondname)
        {
            return UserDbRepository.Instance.AddUser(_firstname, _secondname);
        }

        public static List<Product> AddProduct(string _name, int _price)
        {
            return ProductDbRepository.Instance.AddProduct(_name, _price);
        }

        // for update objects in data base
        public static List<User> UpdateUser (string _id, string _firstname, string _secondname, int _balance)
        {
            return UserDbRepository.Instance.UpdateUser(_id, _firstname, _secondname, _balance);
        }

        public static List<Product> UpdateProduct(string _id, string _name, int _quantity, int price)
        {
            return ProductDbRepository.Instance.UpdateProduct(_id, _name, _quantity, price);
        }

        // for delete objects from data base
        public static List<User> DeleteUser(string _id)
        {
            return UserDbRepository.Instance.DeleteUser(_id);
        } 

        public static List<Product> DeleteProduct(string _id)
        {
            return ProductDbRepository.Instance.DeleteProduct(_id);
        }

        public static List<User> ShowUserDataBase ()
        {
            return UserDbRepository.Instance.GetUserDataBase();
        }

        public static List<Product> ShowProductDataBase()
        {
            return ProductDbRepository.Instance.GetProductDatabase();
        }

        #endregion

        #region for Search operations

        // for search by ID
        public static List<User> SearchIDUser(string _id)
        {
            return UserDbRepository.Instance.SearchUserByID(_id);
        }

        public static List<Product> SearchIDProduct(string _id)
        {
            return ProductDbRepository.Instance.SearchProductByID(_id);
        }

        // for search by name
        public static List<User> SearchUserByName(string _firstname, string _secondname)
        {
            return APIMethods.ConcatUserListsAND
                (
                    UserDbRepository.Instance.SearchUserByFirstName(_firstname),
                    UserDbRepository.Instance.SearchUserBySecondName(_secondname)
                );
        }

        public static List<Product> SearchProductByName(string _name)
        {
            return ProductDbRepository.Instance.SearchProductByName(_name);
        }

        // for search user by balance 
        public static List<User> SearchUserByBalance (int _since, int _until)
        {
            return UserDbRepository.Instance.SearchUserByBalance(_since, _until);
        }

        // for search product by quantity OR price
        public static List<Product> SearchProductByQuantity (int _since, int _until)
        {
            return ProductDbRepository.Instance.SearchProductByQuantity(_since, _until);
        }

        public static List<Product> SearchProductByPrice (int _since, int _until)
        {
            return ProductDbRepository.Instance.SearchProductByPrice(_since, _until);
        }

        #endregion

        #region for other operations

        public static void PlaceAnOrder()
        {

        }

        #endregion
    }

}