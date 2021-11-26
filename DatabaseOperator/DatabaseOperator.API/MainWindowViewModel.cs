using System.Collections.Generic;

using DataBaseOperator.Domain.Core;
using DatabaseOperator.API.Services;

namespace DatabaseOperator.API
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {

        // For show getted objects

        public List<User> userList;
        public List<User> UserList
        {
            get { return userList; }
            set 
            { 
                userList = value;
                CheckChanges();
            }
        }

        public List<Product> productList;

        public List<Product> ProductList
        {
            get { return productList; }
            set
            {
                productList = value;
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
                        DialogWindowOperator.InitializerDialogWindow = new();

                        if (DialogWindowOperator.InitializerDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.InitializerDialogWindow.Show();
                        }
                        UserList = WindowInteractor.StaticUserList;
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
                        DialogWindowOperator.UpdaterDialogWindow = new();
                        
                        if (DialogWindowOperator.UpdaterDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.UpdaterDialogWindow.Show();
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
                        DialogWindowOperator.RemoverDialogWindow = new();

                        if (DialogWindowOperator.RemoverDialogWindow.ShowDialog() == true) 
                        {
                            DialogWindowOperator.RemoverDialogWindow.Show();
                        }
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
                        DialogWindowOperator.IDSearcherDialogWindow = new();

                        if (DialogWindowOperator.IDSearcherDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.IDSearcherDialogWindow.Show();
                        }
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
                        DialogWindowOperator.NameSearcherDialogWindow = new();

                        if (DialogWindowOperator.NameSearcherDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.NameSearcherDialogWindow.Show();
                        }
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
                        DialogWindowOperator.BalanceSearcherDialogWindow = new();

                        if (DialogWindowOperator.BalanceSearcherDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.BalanceSearcherDialogWindow.ShowDialog();
                        }
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
                        DialogWindowOperator.QuantityPriceSearcherDialogWindow = new();

                        if (DialogWindowOperator.QuantityPriceSearcherDialogWindow.ShowDialog() == true)
                        {
                            DialogWindowOperator.QuantityPriceSearcherDialogWindow.Show();
                        }
                    }
                );
            }
        }

        #endregion

        #region for integration and sorting data bases inside

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