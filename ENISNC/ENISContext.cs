using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENISNC.Models;
using static System.Collections.Specialized.BitVector32;

namespace ENISNC
{
    public class ENISContext : DbContext
    {

        public DbSet<User> users { get; set; }
        //public DbSet<> section { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Departement> departements { get; set; }
        public DbSet<Models.Section> sections { get; set; }
        public DbSet<DemandePFE> demandes { get; set; }
        public DbSet<Paper> papers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=LAPTOP-NGVDTDME\SQLEXPRESS;Database=ENISF;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}


