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
        public BlogDbContext() : base("datasource=.;database=blog;integrated security=true;")
        {

        }

        public DbSet<BlogItem> BlogItems { get; set; }
    }
}