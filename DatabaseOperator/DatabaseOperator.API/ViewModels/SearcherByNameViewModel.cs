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
                        DialogWindowOperator.NameSearcherDialogWindow.Close();
                        DialogWindowOperator.NameSearcherDialogWindow = null;
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
