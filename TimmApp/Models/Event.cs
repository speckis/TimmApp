using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimmApp.Models
{
    public class Event
    {
            public int id { get; set; }
            public Employee employee { get; set; }

            public string text { get; set; }

            public DateTime eventStart { get; set; }
            public DateTime eventEnd { get; set; }
    }
}