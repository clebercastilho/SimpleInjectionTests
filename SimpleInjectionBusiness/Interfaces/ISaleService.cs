using SimpleInjectionBusiness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Interface
{
    public interface ISaleService
    {
        IList<SaleModel> GetAllSalesByDate();
    }
}
