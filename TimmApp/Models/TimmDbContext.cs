using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimmApp.Models
{
    public class TimmDbContext : DbContext
    {
        public TimmDbContext()
            : base("TimmDbContext")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> events { get; set; }

        internal void SubmitChanges()
        {
            throw new NotImplementedException();
        }

        internal void InsertOnSubmit()
        {

        }
    }
}