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
                        DialogWindowOperator.UpdaterDialogWindow.Close();
                        DialogWindowOperator.UpdaterDialogWindow = null;
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