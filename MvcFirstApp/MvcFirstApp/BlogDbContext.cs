using MvcFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcFirstApp
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=blog;Data Source=.;")
        {

        }

        public DbSet<BlogItem> BlogItems { get; set; }
    }
}