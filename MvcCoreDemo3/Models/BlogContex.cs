using Microsoft.EntityFrameworkCore;
using MvcCoreDemo3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDemo3.Models
{
    public class BlogContex : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public BlogContex(DbContextOptions<BlogContex> options) : base(options)
        {
            var s = "";
        }
    }
}
