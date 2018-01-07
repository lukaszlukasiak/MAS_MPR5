using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    public class Cat:Pet
    {
        public CatBreed Breed { get; set; }
        public Cat(string name, int age, CatBreed breed)
        {
            Name = name;
            PetType = PetType.Cat;
            Age = age;
            Breed = breed;
        }

        public Cat()
        {
        }
    }
}
