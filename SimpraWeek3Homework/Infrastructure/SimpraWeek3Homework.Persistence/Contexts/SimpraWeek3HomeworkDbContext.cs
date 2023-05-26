using Microsoft.EntityFrameworkCore;
using SimpraWeek3Homework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Persistence.Contexts
{
    public class SimpraWeek3HomeworkDbContext : DbContext
    {
        public SimpraWeek3HomeworkDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
