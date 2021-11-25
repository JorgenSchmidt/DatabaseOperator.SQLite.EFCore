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
                        DialogWindowOperator.IDSearcherDialogWindow.Close();
                        DialogWindowOperator.IDSearcherDialogWindow = null;
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
