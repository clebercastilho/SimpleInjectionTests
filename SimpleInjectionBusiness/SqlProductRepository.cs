using SimpleInjectionBusiness.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IList<string> GetAllProducts(string criteria)
        {
            return new List<string>() { "product1", "product2" };
        }
    }
}
