using System;
using System.Windows;

using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class ObjectInitializatorViewModel : NotifyPropertyChanged
    {

        #region properties

        public string firstameOfUser;
        public string FirstNameOfUser 
        { 
            get { return firstameOfUser; } 
            set
            {
                firstameOfUser = value;
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

        public string nameOfProduct;
        public string NameOfProduct
        {
            get { return nameOfProduct; }
            set
            {
                nameOfProduct = value;
                CheckChanges();
            }
        }

        public int priceOfProduct;
        public int PriceOfProduct
        {
            get { return priceOfProduct; }
            set
            {
                priceOfProduct = value;
                CheckChanges();
            }
        }

        #endregion

        public Command Add
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        // IF
                        if 
                        (!String.IsNullOrEmpty(FirstNameOfUser) && !String.IsNullOrEmpty(SecondNameOfUser)
                        &&
                        String.IsNullOrEmpty(NameOfProduct) && PriceOfProduct == 0
                        )

                        // THEN
                        {
                            //WindowInteractor.StaticUserList = DataBaseInteractor.AddUser(FirstNameOfUser, SecondNameOfUser);

                            DialogWindowOperator.InitializerDialogWindow.Close();
                            DialogWindowOperator.InitializerDialogWindow = null;
                        }

                        // ELSE IF
                        else if
                        (String.IsNullOrEmpty(FirstNameOfUser) && String.IsNullOrEmpty(SecondNameOfUser)
                        &&
                        !String.IsNullOrEmpty(NameOfProduct) && PriceOfProduct != 0)

                        // THEN
                        {
                            //WindowInteractor.StaticProductList = DataBaseInteractor.AddProduct(NameOfProduct, PriceOfProduct);

                            DialogWindowOperator.InitializerDialogWindow.Close();
                            DialogWindowOperator.InitializerDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write information about user OR product.","Error!");
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
                        DialogWindowOperator.InitializerDialogWindow.Close();
                        DialogWindowOperator.InitializerDialogWindow = null;
                    }
                );
            }
        }
    }
}