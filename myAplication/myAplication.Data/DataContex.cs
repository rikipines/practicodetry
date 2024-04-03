using Microsoft.EntityFrameworkCore;
using myAplication.core.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAplication.Data
{
    public class DataContex: DbContext
    {
        public DbSet<Child> Children { get; set; }    

        public DbSet<maneger> manegers { get; set; }

        public DbSet<Parent> parents { get; set; }

        //server=(localdb)\mssqllocaldb;Database=my_db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;Database=my_db");
        }

    }
}
