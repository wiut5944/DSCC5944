﻿using DSCC5944.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSCC5944.Repository
{
   public  interface IProductRepository
    {
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
    }
}
