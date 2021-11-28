using System;
using System.Windows;

using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class ObjectUpdaterViewModel : NotifyPropertyChanged
    {

        #region properties

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

        public string firstNameOfUser;
        public string FirstNameOfUser
        {
            get { return firstNameOfUser; }
            set 
            { 
                firstNameOfUser = value;
                CheckChanges();
            }
        }

        public string secondNameOfUser;
        public string SecondNameOfUser
        {
            get { return secondNameOfUser; }
            set
            {
                secondNameOfUser = value;
                CheckChanges();
            }
        }

        public int userBalance;
        public int UserBalance
        {
            get { return userBalance; }
            set 
            { 
                userBalance = value;
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

        public string productName;
        public string ProductName
        {
            get { return productName; }
            set 
            { 
                productName = value;
                CheckChanges();
            }
        }

        public int quantityOfProduct;
        public int QuantityOfProduct
        {
            get { return quantityOfProduct; }
            set 
            { 
                quantityOfProduct = value;
                CheckChanges();
            }
        }

        public int productPrice;
        public int ProductPrice
        {
            get { return productPrice; }
            set 
            { 
                productPrice = value;
                CheckChanges();
            }
        }

        #endregion

        public Command Update
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        if 
                        (!String.IsNullOrEmpty(UserID) && (!String.IsNullOrEmpty(FirstNameOfUser) || !String.IsNullOrEmpty(SecondNameOfUser) || UserBalance != 0) 
                        && String.IsNullOrEmpty(ProductID) && String.IsNullOrEmpty(ProductName) && QuantityOfProduct == 0 && ProductPrice == 0)
                        {
                            //WindowInteractor.StaticUserList = DataBaseInteractor.UpdateUser(UserID, FirstNameOfUser, SecondNameOfUser, UserBalance);

                            DialogWindowOperator.UpdaterDialogWindow.Close();
                            DialogWindowOperator.UpdaterDialogWindow = null;
                        }
                        else if
                        (String.IsNullOrEmpty(UserID) && String.IsNullOrEmpty(FirstNameOfUser) && String.IsNullOrEmpty(SecondNameOfUser) && UserBalance == 0
                        && !String.IsNullOrEmpty(ProductID) && (!String.IsNullOrEmpty(ProductName) || QuantityOfProduct != 0 || ProductPrice != 0))
                        {
                            //WindowInteractor.StaticProductList = DataBaseInteractor.UpdateProduct(ProductID, ProductName, QuantityOfProduct, ProductPrice);

                            DialogWindowOperator.UpdaterDialogWindow.Close();
                            DialogWindowOperator.UpdaterDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write ID and at least one point of information for update (user OR product). .", "Error!");
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
                        DialogWindowOperator.UpdaterDialogWindow.Close();
                        DialogWindowOperator.UpdaterDialogWindow = null;
                    }
                );
            }
        }

    }
}