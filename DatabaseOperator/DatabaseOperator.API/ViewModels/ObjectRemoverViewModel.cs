using System;
using System.Windows;

using DatabaseOperator.API.Services;
using DataBaseOperator.DAL.Data.SQLite.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class ObjectRemoverViewModel : NotifyPropertyChanged
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

        public Command Delete
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        if 
                        (!String.IsNullOrEmpty(UserID) && DbMethods.IsAIntNumber(UserID)
                        && String.IsNullOrEmpty(ProductID) 
                        && DbMethods.GetUserListLength() > Convert.ToInt32(UserID) )
                        {
                            WindowInteractor.StaticUserList = DataBaseInteractor.DeleteUser(UserID);

                            DialogWindowOperator.RemoverDialogWindow.Close();
                            DialogWindowOperator.RemoverDialogWindow = null;
                        }
                        else if
                        (String.IsNullOrEmpty(UserID)
                        && !String.IsNullOrEmpty(ProductID) && DbMethods.IsAIntNumber(ProductID)
                        && DbMethods.GetProductListLength() > Convert.ToInt32(ProductID))
                        {
                            WindowInteractor.StaticProductList = DataBaseInteractor.DeleteProduct(ProductID);

                            DialogWindowOperator.RemoverDialogWindow.Close();
                            DialogWindowOperator.RemoverDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write user or product ID", "Error!");
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
                        DialogWindowOperator.RemoverDialogWindow.Close();
                        DialogWindowOperator.RemoverDialogWindow = null;
                    }
                );
            }
        }
    }
}
