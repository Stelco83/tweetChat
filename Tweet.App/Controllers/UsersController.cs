namespace Tweet.App.Controllers
{
    using Microsoft.AspNet.Identity;
    using Tweet.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Tweet.App.Models.ViewModels;

    [Authorize]
    public class UsersController : BaseController
    {
        public ActionResult Users()
        {
            var user =this.Data.Users.All()
                .Project()
                .To<UsersViewModel>();
               
            return this.View(user);



        }

        public UsersController(ITweetData data) : base(data)
        {
        }
    }
}