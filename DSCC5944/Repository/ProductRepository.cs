using DSCC5944.DbContexts;
using DSCC5944.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC5944.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId); _dbContext.Products.Remove(product);
            Save();
        }

        public Product GetProductById(int productId)
        {
            var prod = _dbContext.Products.Find(productId); 
            return prod;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products;
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product); Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified; Save();
        }
    }
}
