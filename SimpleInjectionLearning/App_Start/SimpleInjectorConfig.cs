using SimpleInjectionBusiness.Business;
using SimpleInjectionBusiness.Interface;
using SimpleInjectionBusiness.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInjectionLearning
{
    public class SimpleInjectorConfig
    {
        public static void RegisterDependencies()
        {
            var container = new Container();

            container.Register<IProductRepository, ProductRepository>(Lifestyle.Singleton);
            container.Register<IProductService, ProductService>(Lifestyle.Singleton);
            container.Register<ISaleRepository, SqlSaleRepository>(Lifestyle.Singleton);
            container.Register<ISaleService, SaleService>(Lifestyle.Singleton);

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}