using DataBaseOperator.DAL.Data.SQLite.Services;
using DataBaseOperator.Domain.Core;
using DataBaseOperator.Domain.Core.Interfaces;

namespace DataBaseOperator.DAL.Data.SQLite.ProductDAL
{
    public class ProductDbRepository : IProductService
    {

        #region CRUD operations

        // For add target object in data base
        List<Product> IProductService.AddProduct(string _name, int _price)
        {
            using var db = new ProductDbContext();

            var newobj = new Product
            {
                ID = DbMethods.GetFreeIDFromProdList(db.Products.ToList()).ToString(),
                Name = _name,
                Quantity = 0,
                Price = _price
            };

            db.Products.Add(newobj);
            db.SaveChanges();

            return db.Products.ToList();
        }

        // For update information about object
        List<Product> IProductService.UpdateProduct(string _id, string _name, int _quantity, int _price)
        {
            using var db = new ProductDbContext();

            foreach (var curUser in db.Products.ToList())
            {
                if (_id.Equals(curUser.ID))
                {
                    if (!String.IsNullOrEmpty(_name)) curUser.Name = _name;
                    curUser.Quantity += _quantity;
                    curUser.Price = _price;
                    db.Products.Update(curUser);
                    break;
                }
            }

            db.SaveChanges();

            return db.Products.ToList();
        }

        // For delete object from data base
        List<Product> IProductService.DeleteProduct(string _id)
        {
            using var db = new ProductDbContext();

            foreach (var curUser in db.Products.ToList())
            {
                if (_id.Equals(curUser.ID))
                {
                    db.Products.Remove(curUser);
                    break;
                }
            }

            db.SaveChanges();

            return db.Products.ToList();
        }

        // For get target database
        List<Product> IProductService.GetProductDatabase()
        {
            using var db = new ProductDbContext();

            return db.Products.ToList();
        }
        #endregion

        #region Search operations

        List<Product> IProductService.SearchProductByID(string _id)
        {
            using var db = new ProductDbContext();
            List<Product> productList = new ();

            foreach(var cuObj in db.Products.ToList())
            {
                if (_id.Equals(cuObj.ID))
                {
                    productList.Add(cuObj);
                    break;
                }
            }

            return productList;
        }

        List<Product> IProductService.SearchProductByName(string _name)
        {
            using var db = new ProductDbContext();
            List<Product> productList = new();

            foreach (var curObj in db.Products.ToList())
            {
                if (!String.IsNullOrEmpty(curObj.Name))
                {
                    if (DbMethods.SearchMatchesInTheInput(curObj.Name, _name))
                    {
                        productList.Add(curObj);
                    }
                }
            }

            return productList;
        }

        List<Product> IProductService.SearchProductByQuantity(int _sincequantity, int _untilquantity)
        {
            using var db = new ProductDbContext();
            List<Product> productList = new();

            foreach (var curObj in db.Products.ToList())
            {
                if (curObj.Quantity >= _sincequantity && curObj.Quantity <= _untilquantity)
                {
                    productList.Add(curObj);
                }
            }

            return productList;
        }

        List<Product> IProductService.SearchProductByPrice(int _sinceprice, int _untilprice)
        {
            using var db = new ProductDbContext();
            List<Product> productList = new();

            foreach (var curObj in db.Products.ToList())
            {
                if (curObj.Price >= _sinceprice && curObj.Price <= _untilprice)
                {
                    productList.Add(curObj);
                }
            }

            return productList;
        }

        #endregion

    }
}