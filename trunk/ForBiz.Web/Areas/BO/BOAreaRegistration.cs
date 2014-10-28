﻿using System.Web.Mvc;

namespace ForBiz.Web.Areas.BO
{
    public class BOAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BO";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BO_default",
                "BO/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}