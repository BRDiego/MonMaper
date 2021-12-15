using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DBControl.Data
{
    public class MonMaperContext : DbContext
    {

        public class ApplicationDbContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql("server=localhost;userid=developer;password=diego#dev;database=monmaperdb",
                    new MySqlServerVersion( new Version(8, 0, 27)));
            }
        }

        public DbSet<Income> Incomes;
        public DbSet<Expenditure> Expenditures;
    }
}
