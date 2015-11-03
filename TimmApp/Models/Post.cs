using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimmApp.Models
{
    public enum Priority
    {
        First = 1,
        Second = 2,
        Third = 3,
        Forth = 4,
        Fifth = 5,
    }
    public class Post
    {
        public int postId { get; set; }

        [Required(ErrorMessage = "There is no post without some text. Please write something")]
        [Display(Name = "Post")]
        [StringLength(255)]
        public string postMsg { get; set; }

        [Display(Name = "Priority level")]
        public Priority priority { get; set; }
    }

    public class PostDbContext : DbContext
    {
        public PostDbContext() : base("PostDbContext") 
        { 
        }

        public DbSet<Post> Posts { get; set; }
    }
}