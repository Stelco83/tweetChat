namespace Tweet.Data
{
    using System;
    using System.Collections.Generic;
    using Tweet.Data;
    using Tweet.Models;
    using Tweet.Data.Repositories;


    public class TweetsData : ITweetData
    {
        private ITweetDbContext context;
        private IDictionary<Type, object> repositories;

        public TweetsData(ITweetDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Profile> Profiles
        {
            get { return this.GetRepository<Profile>(); }
        }

        public IRepository<Report> Reports
        {
            get { return this.GetRepository<Report>(); }
        }

        public IRepository<Tweet> Tweets
        {
            get { return this.GetRepository<Tweet>(); }
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }


        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);


                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}
