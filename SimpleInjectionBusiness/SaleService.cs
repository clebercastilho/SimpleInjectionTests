using SimpleInjectionBusiness.Interface;
using SimpleInjectionBusiness.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Business
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public IList<SaleModel> GetAllSalesByDate()
        {
            return _saleRepository.GetAllSales(string.Empty);
        }
    }
}
