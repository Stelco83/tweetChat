﻿namespace Tweet.App.Models.ViewModels
{
    using Tweet.Common.Mappings;
    using System;
    using System.Collections.Generic;
    using Tweet.Models;

    public class TweetViewModel : IMapFrom<Tweet>
    {

        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime DatePosted { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public string URL { get; set; }

        public virtual ICollection<User> FavoriteByUsers { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }

}