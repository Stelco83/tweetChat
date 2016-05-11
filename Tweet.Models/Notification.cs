using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tweet.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; } 

        public virtual User User { get; set; }

        public bool IsNotified { get; set; }
    }
}