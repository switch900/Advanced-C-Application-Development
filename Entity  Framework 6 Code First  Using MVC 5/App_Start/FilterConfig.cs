﻿using System.Web;
using System.Web.Mvc;

namespace COMP3618_Midterm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
