namespace MAS_MPR5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MAS_MPR5.Models;
    using MAS_MPR5.DAL;

    public partial class DBPetMangerContext : DbContext
    {
        public DBPetMangerContext()
            : base("name=DBPetMangerContext")
        {
            this.Database.CommandTimeout = 300;

        }

        //public virtual DbSet<database_firewall_rules> Database_firewall_rules { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<database_firewall_rules>()
        //        .Property(e => e.start_ip_address)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<database_firewall_rules>()
        //        .Property(e => e.end_ip_address)
        //        .IsUnicode(false);
        //}
        static DBPetMangerContext()
        {
            Database.SetInitializer(new PetManagerInitializer());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Cat> Cats { get; set; }

    }
}
