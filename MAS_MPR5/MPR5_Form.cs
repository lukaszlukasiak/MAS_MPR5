using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAS_MPR5.DAL;
using System.Data.Entity;
using MAS_MPR5.Models;
using System.Runtime.Remoting.Contexts;

namespace MAS_MPR5
{
    public partial class MPR5_Form : Form
    {
        public DBPetMangerContext dbContext;

        public MPR5_Form()
        {
            InitializeComponent();
        }

        private void splitContainer3_Panel2_SizeChanged(object sender, EventArgs e)
        {
            label1.Height= splitContainer3.Height;
            
        }

        private void splitContainer3_SizeChanged(object sender, EventArgs e)
        {
            label1.Height = splitContainer3.Height;
        }

        private void splitContainer2_Panel2_SizeChanged(object sender, EventArgs e)
        {
            label2.Height = splitContainer2.Height;
        }

        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            label3.Height = splitContainer1.Height;
        }

        private void MPR5_Form_Load(object sender, EventArgs e)
        {


            BindingSource bsOwners = new BindingSource
            {
                DataSource = dbContext.Persons.Local.ToBindingList()
            };
            lsbExplorePersons.DataSource = bsOwners;
            lsbPersonsList.DataSource = bsOwners;
            lsbExplorePersons.DisplayMember = "UserName";
            lsbPersonsList.DisplayMember = "UserName";
            // this.dgvUsers.DataSource = dbContext.Users.Local;
            //this.dgvUsers.Update();
            lsbPetsList.DisplayMember = "Name";


            BindingList<Pet> pets = new BindingList<Models.Pet>();
            foreach (var item in dbContext.Cats.Local.ToBindingList())
            {
                pets.Add(item);
            }
            foreach (var item in dbContext.Dogs.Local.ToBindingList())
            {
                pets.Add(item);
            }

           
            lsbPetsList.DataSource = pets;

            // this.dgvUsers.DataSource = dbContext.Users.Local;
            //this.dgvBooks.Update();

        }

        private void lsbPersonsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            tbxAge.Text = person.Age.ToString();
            tbxCity.Text = person.City;
            tbxName.Text = person.Name;
            tbxSurname.Text = person.Surname;
            tbxUserName.Text = person.UserName;
        }

        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxAge_Validating(object sender, CancelEventArgs e)
        {
            bool numeric;
            int age;

            numeric = int.TryParse(tbxAge.Text, out age);
            if (!numeric)
            {
                MessageBox.Show("Wprowadź wartosć liczbową!");
                e.Cancel = true;
            }
        }

        private void tbxAge_Validated(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            person.Age = int.Parse( tbxAge.Text);
            dbContext.SaveChanges();
        }

        private void tbxUserName_Validated(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            person.UserName = tbxUserName.Text;
            dbContext.SaveChanges();
        }

        private void tbxName_Validated(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            person.Name = tbxName.Text;
            dbContext.SaveChanges();
        }

        private void tbxSurname_Validated(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            person.Surname = tbxSurname.Text; ;
            dbContext.SaveChanges();

        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            Person person = (Person)lsbExplorePersons.SelectedItem;
            person.City = tbxCity.Text;
            dbContext.SaveChanges();

        }

        private void lsbPetsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pet pet = (Pet)lsbPetsList.SelectedItem;
            tbxPetAge.Text = pet.Age.ToString();
            tbxPetName.Text = pet.Name;
            tbxPetType.Text = pet.PetType.ToString();
            if (pet.PetType==PetType.Cat )
            {
              //  tbxBreedSpecies.Text = ((Cat)pet).Breed.ToString();
            }
            else if ( pet.PetType == PetType.Dog)
            {
              //  tbxBreedSpecies.Text = ((Dog)pet).Breed.ToString();
            }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
