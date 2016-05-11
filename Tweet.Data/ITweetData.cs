using Tweet.Data.Repositories;

namespace Tweet.Data
{
    using System.Text.RegularExpressions;

    using Tweet.Data.Repositories;
    using Tweet.Models;

    public interface ITweetData
    {
        IRepository<User> Users { get; }

        IRepository<Profile> Profiles { get; }
        
        IRepository<Report> Reports { get; }

        IRepository<Tweet> Tweets { get; }

        int SaveChanges();
    }
}
