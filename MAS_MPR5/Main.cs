using MAS_MPR5.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_MPR5
{
    public static class Main
    {

        public static void Start()
        {
            MPR5_Form form = new MPR5_Form();
            form.dbContext = new DBPetMangerContext();
            form.dbContext.Database.Initialize(true);
            form.dbContext.Persons.Load();
            form.dbContext.Cats.Load();
            form.dbContext.Dogs.Load();
            form.Show();


        }

    }
}
