﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectionBusiness.Interface
{
    public interface IProductRepository
    {
        IList<string> GetAllProducts(string criteria);
    }
}
