using System.Windows;

using DatabaseOperator.API.Views;

namespace DatabaseOperator.API.Services
{
    public class DialogWindowOperator : Window
    {

        // for every dialog window i use one static window object

        public static ObjectInitializatorWindow InitializerDialogWindow;
        public static ObjectUpdaterWindow UpdaterDialogWindow;
        public static ObjectRemoverWindow RemoverDialogWindow;

        public static SearcherByIDWindow IDSearcherDialogWindow;
        public static SearcherByNameWindow NameSearcherDialogWindow;
        public static SearcherByUserBalanceWindow BalanceSearcherDialogWindow;
        public static SearcherByQuantityPriceWindow QuantityPriceSearcherDialogWindow;

        public static PlaceAnOrderWindow PlaceAnOrderDialogWindow;
    }
}