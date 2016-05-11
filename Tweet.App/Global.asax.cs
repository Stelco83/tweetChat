using System.Reflection;

namespace Tweet.App
{

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Tweet.Common.Mappings;
    using Tweet.Data;
    using Tweet.Data.Migrations;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                new  MigrateDatabaseToLatestVersion<TweetDbContext, Configuration>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            var autoMapperConfig = new AutoMapperConfig(new List<Assembly>
                {
                Assembly.GetExecutingAssembly()
                });


            autoMapperConfig.Execute();
        }
    }
} 
