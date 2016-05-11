using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tweet.Models;

namespace Tweet.Models
{
    public class Profile
    {   

        public string Image { get; set; }

        public virtual User User { get; set; }

        [Required]
        [Key, ForeignKey("User")]
        public string UserId { get; set; }
    }
}