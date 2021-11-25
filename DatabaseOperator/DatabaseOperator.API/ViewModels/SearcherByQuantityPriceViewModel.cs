using DatabaseOperator.API.Services;

namespace DatabaseOperator.API.ViewModels
{
    public class SearcherByQuantityPriceViewModel : NotifyPropertyChanged
    {

        public int quantityOfProductSince;
        public int QuantityOfProductSince
        {
            get { return quantityOfProductSince; }
            set
            {
                quantityOfProductSince = value;
                CheckChanges();
            }
        }

        public int quantityOfProductUntil;
        public int QuantityOfProductUntil
        {
            get { return quantityOfProductUntil; }
            set
            {
                quantityOfProductUntil = value;
                CheckChanges();
            }
        }

        public int productPriceSince;
        public int ProductPriceSince
        {
            get { return productPriceSince; }
            set
            {
                productPriceSince = value;
                CheckChanges();
            }
        }

        public int productPriceUntil;
        public int ProductPriceUntil
        {
            get { return productPriceUntil; }
            set
            {
                productPriceUntil = value;
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
                        DialogWindowOperator.QuantityPriceSearcherDialogWindow.Close();
                        DialogWindowOperator.QuantityPriceSearcherDialogWindow = null;
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
                        DialogWindowOperator.QuantityPriceSearcherDialogWindow.Close();
                        DialogWindowOperator.QuantityPriceSearcherDialogWindow = null;
                    }
                );
            }
        }

    }
}
