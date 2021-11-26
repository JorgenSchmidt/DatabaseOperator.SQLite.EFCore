using System.Windows;
using System.Collections.Generic;

using DatabaseOperator.API.Views;
using DataBaseOperator.Domain.Core;

namespace DatabaseOperator.API.Services
{
    public class DialogWindowOperator : Window
    {

        public static ObjectInitializatorWindow InitializerDialogWindow;
        public static ObjectUpdaterWindow UpdaterDialogWindow;
        public static ObjectRemoverWindow RemoverDialogWindow;

        public static SearcherByIDWindow IDSearcherDialogWindow;
        public static SearcherByNameWindow NameSearcherDialogWindow;
        public static SearcherByUserBalanceWindow BalanceSearcherDialogWindow;
        public static SearcherByQuantityPriceWindow QuantityPriceSearcherDialogWindow;
    }
}