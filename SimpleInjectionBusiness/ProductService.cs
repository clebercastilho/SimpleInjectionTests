using SimpleInjectionBusiness.Interface;
using SimpleInjectionBusiness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Business
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<string> GetAllProductsByStatus()
        {
            var criteria = "Status=1";
            return _productRepository.GetAllProducts(criteria);
        }
    }
}
