using DatabaseOperator.API.Services;

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
                        DialogWindowOperator.RemoverDialogWindow.Close();
                        DialogWindowOperator.RemoverDialogWindow = null;
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
