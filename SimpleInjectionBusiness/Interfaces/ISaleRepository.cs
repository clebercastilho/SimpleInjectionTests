using SimpleInjectionBusiness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Interface
{
    public interface ISaleRepository
    {
        IList<SaleModel> GetAllSales(string criteria);
    }
}
