using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    class Parrot:Pet
    {
        public ParrotSpecies Species { get; set; }
        public Parrot(string name, int age, ParrotSpecies species)
        {
            Name = name;
            PetType = PetType.Parrot;
            Age = age;
            Species = species;
        }

    }
}
