namespace DataBaseOperator.Domain.Core.Interfaces
{
    public interface IProductService
    {
        List<Product> AddProduct(string _name, int _price);
        List<Product> UpdateProduct(string _id, string _name, int _quantity, int _price);
        List<Product> DeleteProduct(string _id);
        List<Product> GetProductDatabase();

        List<Product> SearchProductByID(string _id);
        List<Product> SearchProductByName(string _name);
        List<Product> SearchProductByQuantity(int _sincequantity, int _untilquantity);
        List<Product> SearchProductByPrice(int _sinceprice, int _untilprice);
    }
}
