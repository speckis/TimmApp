using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimmApp.Models
{
    public class PostViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

        public string postMsg { get; set; }

        public Priority priority { get; set; }
    }
}