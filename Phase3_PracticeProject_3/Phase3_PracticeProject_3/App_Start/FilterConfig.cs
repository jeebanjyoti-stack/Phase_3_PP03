﻿using System.Web;
using System.Web.Mvc;

namespace Phase3_PracticeProject_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
