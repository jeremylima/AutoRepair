using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface IProductManagementService : IDisposable
    {
        IEnumerable<ProductConsult> GetAllProducts();
        void Add(Product product);
        void Update(Product product);
        Product GetProduct(int productId);
        void Delete(Product product);
    }
}