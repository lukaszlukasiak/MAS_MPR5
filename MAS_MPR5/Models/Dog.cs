using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    public class Dog:Pet,  IEnumerable
    {
        public DogBreed Breed { get; set; }
        public Dog(string name,  int age,  DogBreed breed)
        {
            Name = name;
            PetType = PetType.Dog;
            Age = age;
            Breed = breed;
        }

        public Dog()
        {
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
