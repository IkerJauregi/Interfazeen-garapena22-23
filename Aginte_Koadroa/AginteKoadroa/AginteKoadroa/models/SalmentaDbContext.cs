using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.models
{
    public class SalmentaDbContext : DbContext
    {
        //Bertan app.config fitxategian idatzitakoaren berdina jarri behar da.
        public SalmentaDbContext() : base(nameOrConnectionString: "SalmentaDbContext")
        { }
        public DbSet<Bezeroa> Bezeroa { get; set; }
        public DbSet<Salmenta> Salmenta { get; set; }
        public DbSet<Saltzailea> Saltzailea { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}