using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SOLID.Models;

namespace SOLID.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<SOLID.Models.User> User { get; set; }
        public DbSet<SOLID.Models.Animal> Animal { get; set; }
        public DbSet<SOLID.Models.ExtraService> ExtraService { get; set; }
        public DbSet<SOLID.Models.DayService> DayService { get; set; }
        public DbSet<SOLID.Models.Invoice> Invoice { get; set; }
    }
}
