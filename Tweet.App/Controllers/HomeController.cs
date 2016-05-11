using System;
using System.Web.UI.WebControls;

namespace Tweet.App.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Tweet.App.Models.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Tweet.Data;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            var allTweets = this.Data.Tweets.All()
                .OrderByDescending(x => x.DatePosted)
                .Take(10)
                .Project()
                .To<TweetViewModel>();      
            return this.View(allTweets);
          
        }

        public HomeController(ITweetData data) : base(data)
        {
        }
    }
}