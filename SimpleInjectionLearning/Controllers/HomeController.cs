using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInjectionBusiness.Interface;

namespace SimpleInjectionLearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISaleService _saleService;

        public HomeController(IProductService productService, ISaleService saleService)
        {
            _productService = productService;
            _saleService = saleService;
        }

        public ActionResult Index()
        {
            var productList = _productService.GetAllProductsByStatus();
            var sales = _saleService.GetAllSalesByDate();

            return View();
        }

        #region Actions sem uso
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        #endregion
    }
}