﻿using System.Web;
using System.Web.Mvc;

namespace _1811062988_LeDuyKhanh_Tuan3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
