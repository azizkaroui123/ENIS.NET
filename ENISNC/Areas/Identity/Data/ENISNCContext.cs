using ENISNC.Areas.Identity.Data;
using ENISNC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ENISNC.Areas.Identity.Data;

public class ENISNCContext : IdentityDbContext<ENISNCUser>
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
        optionsbuilder.UseSqlServer(@"Server=LAPTOP-A7SDFKGC\SQLEXPRESS;Database=ENISFnewnew;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public ENISNCContext(DbContextOptions<ENISNCContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
