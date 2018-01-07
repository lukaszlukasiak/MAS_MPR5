using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    class Rabbit:Pet
    {
        public RabbitBreed Breed { get; set; }
        public Rabbit(string name, int age, RabbitBreed breed)
        {
            Name = name;
            PetType = PetType.Rabbit;
            Age = age;
            Breed = breed;
        }

    }
}
