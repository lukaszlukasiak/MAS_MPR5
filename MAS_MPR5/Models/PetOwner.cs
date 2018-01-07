using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5.Models
{
    public class PetOwner: Person
    {
        public virtual List<Pet> Pets { get; set; }

        public override string ToString()
        {
            return this.Name + " " +this.Surname;
        }
    }
}
