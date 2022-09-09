using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productID)
        {
            _connection.Execute("Delete from sales where product id = @id",new{ id = productID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM Products;");
        }

        public Product GetProductById(int productID)
        {
            return _connection.QuerySingle<Product>("Select * from products where productID = @id ",
                new { productID });
        }

        public void UpdateProduct(Product product)
        {
            _connection.Execute("Update products set name = @name, price = @price, where product id =@productID",
                new
                {
                    name = product.Name,
                    price = product.ProductID,

                });
        }
       
    }
}
