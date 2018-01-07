using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    public abstract class Pet
    {
        [Key]
        public int PetID { get; set; }

        public string Name { get; set; }
        public PetType PetType { get; set; }
        public int Age { get; set; }

        //[ForeignKey("OwnerID")]
        //public int OwnerID { get; set; }
        public virtual PetOwner Owner { get; set; }

        //abstract Pet(string name, PetType type,int age, PetOwner owner )
        //{
        //    Name = name;
        //    PetType = type;
        //    Age = age;
        //    Owner = owner;
        //}
    }
}
