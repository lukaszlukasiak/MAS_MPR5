using MAS_MPR5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.DAL
{
    public class PetOwnershipContext:DbContext
    {
        public PetOwnershipContext() : base("PetOwnershipContext")
        {

        }
        static PetOwnershipContext()
        {
            Database.SetInitializer(new PetManagerInitializer());
        }

        public static PetOwnershipContext Create()
        {
            return new PetOwnershipContext();
        }

        public DbSet<Person> Persons { get; set; }
        //public DbSet<PetOwner> PetOwners { get; set; }
        //public DbSet<Cat> Pets { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        public DbSet<Cat> Cats { get; set; }
        //public DbSet<Pet> Dogs { get; set; }
        //public DbSet<Pet> Pets { get; set; }


    }
}
