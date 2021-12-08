using System;
using System.Windows;

using DatabaseOperator.API.Services;
using DataBaseOperator.Domain.Core;
using DataBaseOperator.DAL.Data.SQLite.ProductDAL;
using DataBaseOperator.DAL.Data.SQLite.UserDAL;
using DataBaseOperator.DAL.Data.SQLite.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class PlaceAnOrderDialogViewModel : NotifyPropertyChanged
    {
        public string userID;
        public string UserID
        {
            get { return userID; }
            set
            {
                userID = value;
                CheckChanges();
            }
        }

        public string productID;
        public string ProductID
        {
            get { return productID; }
            set
            {
                productID = value;
                CheckChanges();
            }
        }

        public int quantityProduct;

        public int QuantityProduct
        {
            get { return quantityProduct; }
            set 
            { 
                quantityProduct = value; 
                CheckChanges();
            }
        }

        public Command Send
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                        if 
                        (!String.IsNullOrEmpty(UserID) && !String.IsNullOrEmpty(ProductID) && QuantityProduct > 0 
                        && 
                        DbMethods.IsAIntNumber(UserID) && DbMethods.IsAIntNumber(ProductID)
                        && 
                        DbMethods.GetUserListLength() > Convert.ToInt32(UserID) && DbMethods.GetProductListLength() > Convert.ToInt32(ProductID))
                        {

                            User targetUser = UserDbRepository.Instance.SearchUserByID(UserID)[0];
                            Product targetProduct = ProductDbRepository.Instance.SearchProductByID(ProductID)[0];

                            if (targetUser.Balance >= targetProduct.Price * QuantityProduct && targetProduct.Quantity >= QuantityProduct)
                            {
                                DataBaseInteractor.PlaceAnOrder(targetUser, targetProduct, QuantityProduct);

                                DialogWindowOperator.PlaceAnOrderDialogWindow.Close();
                                DialogWindowOperator.PlaceAnOrderDialogWindow = null;
                            }
                            else
                            {
                                MessageBox.Show("Balance was less than price * quantity or input of quantity was less than writed quantity.", "Error!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("You have to write all parameters. Also ID of user or product have to exist", "Error!");
                        }

                    }
                );
            }
        }

        public Command Close
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        DialogWindowOperator.PlaceAnOrderDialogWindow.Close();
                        DialogWindowOperator.PlaceAnOrderDialogWindow = null;
                    }
                );
            }
        }

    }
}