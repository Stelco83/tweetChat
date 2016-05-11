using Tweet.Data;

namespace Tweet.App.Controllers
{
    using System.Web.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;


    public abstract class BaseController : Controller
    {
        protected BaseController(ITweetData data)
        {
            this.Data = data;
        }

        protected ITweetData Data { get; private set; }
    }
}