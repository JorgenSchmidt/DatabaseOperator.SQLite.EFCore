using System.Collections.Generic;

using DataBaseOperator.Domain.Core;
using DatabaseOperator.API.Services;
using DatabaseOperator.API.ViewModels;
using System.Windows;
using DatabaseOperator.API.Views;

namespace DatabaseOperator.API
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {

        // For show getted objects
        public List<User> userlist;

        public List<User> UserList
        {
            get { return userlist; }
            set
            {
                userlist = value;
                CheckChanges();
            }
        }

        public List<Product> productlist;

        public List<Product> ProductList
        {
            get { return productlist; }
            set
            {
                productlist = value;
                CheckChanges();
            }
        }

        #region operations for change data bases

        public Command AddObject
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        DialogWindowOperator.InitializeDialogWindow = new();

                        if (DialogWindowOperator.InitializeDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.InitializeDialogWindow.Show();
                        }
                    }
                );
            }
        }

        public Command UpdateObject
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {
                        DialogWindowOperator.UpdateDialogWindow = new();
                        
                        if (DialogWindowOperator.UpdateDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.UpdateDialogWindow.Show();
                        }
                    }
                );
            }
        }

        public Command DeleteObject
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command ReadDataBase
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        #endregion

        #region operations for search information in data bases

        public Command SearchByID
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command SearchByName
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command SearchByUserBalance
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command SearchByProductQuantityOrPrice
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        #endregion

        #region for integration and sorting data bases

        public Command IntegrationToUserDb
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command IntegrationToProductDb
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command SortUserDb
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        public Command SortProductDb
        {
            get
            {
                return new Command
                (
                    (obj) =>
                    {

                    }
                );
            }
        }

        #endregion

    }
}