using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourismWeb.Models
{
    public class PostShare
    {
        [Key]
        public int ShareId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        [Required, MaxLength(50)]
        public string SharedOn { get; set; } = "";

        public DateTime SharedAt { get; set; } = DateTime.Now;
    }
}