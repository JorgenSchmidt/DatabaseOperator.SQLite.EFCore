using System.Windows;

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
                        if (UserBalanceSince > 0 && UserBalanceUntil > 0 && UserBalanceSince <= UserBalanceUntil)
                        {
                            //WindowInteractor.StaticUserList = DataBaseInteractor.SearchUserByBalance(UserBalanceSince, UserBalanceUntil);

                            DialogWindowOperator.BalanceSearcherDialogWindow.Close();
                            DialogWindowOperator.BalanceSearcherDialogWindow = null;
                        }
                        else
                        {
                            MessageBox.Show("You have to write the lower and upper bounds of the range.", "Error!");
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
                        DialogWindowOperator.BalanceSearcherDialogWindow.Close();
                        DialogWindowOperator.BalanceSearcherDialogWindow = null;
                    }
                );
            }
        }

    }
}
