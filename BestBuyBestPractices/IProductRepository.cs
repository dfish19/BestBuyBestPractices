using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void CreateProduct(string name, double price, int categoryID);
        public Product GetProductById(int productID);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int productID);
    }
}
