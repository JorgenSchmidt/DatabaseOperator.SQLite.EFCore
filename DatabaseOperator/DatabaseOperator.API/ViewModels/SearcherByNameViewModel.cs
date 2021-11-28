using System;
using System.Windows;

using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class SearcherByNameViewModel : NotifyPropertyChanged
    {

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

        public Command Search
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        if (!String.IsNullOrEmpty(FirstNameOfUser) && !String.IsNullOrEmpty(SecondNameOfUser) && String.IsNullOrEmpty(ProductName))
                        {
                            //WindowInteractor.StaticUserList = DataBaseInteractor.SearchUserByName(FirstNameOfUser, SecondNameOfUser);

                            DialogWindowOperator.NameSearcherDialogWindow.Close();
                            DialogWindowOperator.NameSearcherDialogWindow = null;
                        }
                        else if (String.IsNullOrEmpty(FirstNameOfUser) && String.IsNullOrEmpty(SecondNameOfUser) && !String.IsNullOrEmpty(ProductName))
                        {
                            //WindowInteractor.StaticProductList = DataBaseInteractor.SearchProductByName(ProductName);

                            DialogWindowOperator.NameSearcherDialogWindow.Close();
                            DialogWindowOperator.NameSearcherDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write information about user or product", "Error!");
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
                        DialogWindowOperator.NameSearcherDialogWindow.Close();
                        DialogWindowOperator.NameSearcherDialogWindow = null;
                    }
                );
            }
        }

    }
}
