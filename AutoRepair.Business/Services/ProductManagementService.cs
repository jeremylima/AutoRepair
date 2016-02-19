using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class ProductManagementService : IProductManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Product> _productRepository;

        public ProductManagementService(IIntKeyedRepository<DataAccess.Entities.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            _productRepository.Dispose();
        }


        public IEnumerable<ProductConsult> GetAllProducts()
        {
            return _productRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Product, ProductConsult>);
        }

        public void Add(Product product)
        {
            var _product = _productRepository.FindBy(x => x.Code == product.Code);
            if (_product != null)
                throw new DuplicatedEntryKeyException();

            _productRepository.Add(AutoMapper.Mapper.Map<Product, DataAccess.Entities.Product>(product));
        }

        public void Update(Product product)
        {
            var _product = _productRepository.FindBy(x => x.Code == product.Code);
            if (_product != null)
            {
                if (_product.Id != product.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _productRepository.Update(AutoMapper.Mapper.Map<Product, DataAccess.Entities.Product>(product));
        }

        public Product GetProduct(int productId)
        {
            var product = _productRepository.FindBy(productId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Product, Product>(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(AutoMapper.Mapper.Map<Product, DataAccess.Entities.Product>(product));
        }
    }
}