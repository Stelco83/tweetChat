using Tweet.Common.Mappings;
using Tweet.Models;

namespace Tweet.App.Models.ViewModels
{
    using System.Collections.Generic;

    public class UsersViewModel : IMapFrom<User>
    {

        public string Id { get; set; }

        public string Email { get; set; }

        public string PictureUrl { get; set; }

        public virtual ICollection<TweetViewModel> Tweet { get; set; }

    }
}