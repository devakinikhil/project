using SimaxCrm.Data.Repository.Interface;
using SimaxCrm.Model.Entity;
using SimaxCrm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimaxCrm.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product product)
        {
            _productRepository.Insert(product);
        }

        public void Delete(int id)
        {
            var obj = _productRepository.SearchFor(x => x.Id == id).FirstOrDefault();
            obj.UpdatedDate = DateTime.Now;
            obj.Status = false;
            _productRepository.UpdateEntity(obj);
        }

        public void Update(Product product)
        {
            _productRepository.UpdateEntity(product);
        }

        public List<Product> List()
        {
            return _productRepository.SearchFor(m => m.Status).OrderByDescending(x => x.Id).ToList();
        }

        public Product ById(int id)
        {
            return _productRepository.SearchFor(x => x.Id == id).FirstOrDefault();
        }
    }
}
