using System.Web.Mvc;
using System.Web.UI.WebControls;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Tweet.App.Models.BindingModels;
using Tweet.Data;


namespace Tweet.App.Controllers
{
    using System;

    using System.Web.Http;

    public class TweetsController : BaseController
    {
        public TweetsController(ITweetData data) : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InputTweetModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                model.UserId = this.User.Identity.GetUserId();
                var tweet = Mapper.Map<Tweet.Models.Tweet>(model);
                tweet.DatePosted = DateTime.Now;
                tweet.URL = "1";
                this.Data.Tweets.Add(tweet);
                this.Data.SaveChanges();
            }
          // userPicLink  "https://avatars0.githubusercontent.com/u/10682424?v=3&s=400";
            return RedirectToAction("Index", "Home");
        }
    }
}
