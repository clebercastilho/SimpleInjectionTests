using SimpleInjectionBusiness.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Repository
{
    public class SqlSaleRepository : ISaleRepository
    {
        public IList<SaleModel> GetAllSales(string criteria)
        {
            return new List<SaleModel>()
            {
                new SaleModel { ID = 1, Date = DateTime.Now },
                new SaleModel { ID = 2, Date = DateTime.Now },
                new SaleModel { ID = 3, Date = DateTime.Now }
            };
        }
    }

    public class SaleModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<string> Products { get; set; }

        public SaleModel()
        {
            Products = new List<string>();
        }
    }
}
