namespace Tweet.Data
{
using System.Data.Entity;
using Tweet.Models;
  

    public interface ITweetDbContext
    {
        IDbSet<Profile> Profiles { get; set; }

        IDbSet<Report> Reports { get; set; }

        IDbSet<Tweet> Tweets { get; set; }

        IDbSet<User> Users { get; set; }

        int SaveChanges();
    }
}
