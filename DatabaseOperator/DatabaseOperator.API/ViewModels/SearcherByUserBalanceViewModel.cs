using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class SearcherByUserBalanceViewModel : NotifyPropertyChanged
    {

        public int userBalanceSince;
        public int UserBalanceSince
        {
            get { return userBalanceSince; }
            set
            {
                userBalanceSince = value;
                CheckChanges();
            }
        }

        public int userBalanceUntil;
        public int UserBalanceUntil
        {
            get { return userBalanceUntil; }
            set
            {
                userBalanceUntil = value;
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
                        DialogWindowOperator.BalanceSearcherDialogWindow.Close();
                        DialogWindowOperator.BalanceSearcherDialogWindow = null;
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
                        DialogWindowOperator.BalanceSearcherDialogWindow.Close();
                        DialogWindowOperator.BalanceSearcherDialogWindow = null;
                    }
                );
            }
        }

    }
}
