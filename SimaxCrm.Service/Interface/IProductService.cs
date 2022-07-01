using SimaxCrm.Model.Entity;
using System.Collections.Generic;

namespace SimaxCrm.Service.Interface
{
    public interface IProductService
    {
        List<Product> List();
        Product ById(int id);
        void Create(Product serviceType);
        void Update(Product serviceType);
        void Delete(int id);
    }
}
