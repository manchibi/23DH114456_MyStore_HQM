﻿using System.Web;
using System.Web.Mvc;

namespace _23DH114456_MyStore_HQM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
