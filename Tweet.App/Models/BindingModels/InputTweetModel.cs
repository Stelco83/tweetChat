namespace Tweet.App.Models.BindingModels
    {
        using System;
        using Tweet.Common.Mappings;
        using Tweet.Models;

        public class InputTweetModel : IMapTo<Tweet>
        {
            public int Id { get; set; }

            public string Text { get; set; }

            public DateTime DatePosted { get; set; }

            public string UserId { get; set; }

            public virtual User User { get; set; }

            public string URL { get; set; }
        }
    }