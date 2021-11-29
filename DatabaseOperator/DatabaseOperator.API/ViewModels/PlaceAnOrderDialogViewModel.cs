using System;
using System.Windows;

using DatabaseOperator.API.Services;
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
                        if (!String.IsNullOrEmpty(UserID) && !String.IsNullOrEmpty(ProductID) && QuantityProduct != 0)
                        {

                            DialogWindowOperator.PlaceAnOrderDialogWindow.Close();
                            DialogWindowOperator.PlaceAnOrderDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write all parameters", "Error!");
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
