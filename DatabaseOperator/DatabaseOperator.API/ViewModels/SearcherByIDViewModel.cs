using System;
using System.Windows;

using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class SearcherByIDViewModel : NotifyPropertyChanged
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

        public Command Search
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                        if (!String.IsNullOrEmpty(UserID) && String.IsNullOrEmpty(ProductID))
                        {
                            //WindowInteractor.StaticUserList = DataBaseInteractor.SearchIDUser(UserID);

                            DialogWindowOperator.IDSearcherDialogWindow.Close();
                            DialogWindowOperator.IDSearcherDialogWindow = null;
                        }
                        else if (String.IsNullOrEmpty(UserID) && !String.IsNullOrEmpty(ProductID))
                        {
                            //WindowInteractor.StaticProductList = DataBaseInteractor.SearchIDProduct(ProductID);

                            DialogWindowOperator.IDSearcherDialogWindow.Close();
                            DialogWindowOperator.IDSearcherDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write user ID or product ID.", "Error!");
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
                        DialogWindowOperator.IDSearcherDialogWindow.Close();
                        DialogWindowOperator.IDSearcherDialogWindow = null;
                    }
                );
            }
        }

    }
}
