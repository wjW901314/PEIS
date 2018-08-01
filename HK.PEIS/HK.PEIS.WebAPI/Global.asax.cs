using HK.PEIS.Utility.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HK.PEIS.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //webapi请求监控日志
            //GlobalConfiguration.Configuration.Filters.Add(new WebApiTrackerAttribute());

            //log4net日志
            LogHelper.SetConfig();

            //AutoMapper配置映射初始化
            //AutoMapperConfiguration.Configure();
        }
    }
}
