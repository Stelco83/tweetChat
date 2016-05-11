namespace Tweet.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tweet.Models;

    public class TweetDbContext : IdentityDbContext<User>, ITweetDbContext
    {
        public TweetDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TweetDbContext Create()
        {
            return new TweetDbContext();
        }

        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Report> Reports { get; set; }

        public IDbSet<Profile> Profiles { get; set; }

        public IDbSet<Notification> Notifications { get; set; }

    }
}
