using System;
using System.Data.Entity;
using System.Collections.Generic;
using MAS_MPR5.Models;

namespace MAS_MPR5.DAL
{
    internal class PetManagerInitializer : DropCreateDatabaseAlways<DBPetMangerContext>
    {
        //public void InitializeDatabase(object context)
        //{
        //    throw new NotImplementedException();
        //}
        protected override void Seed(DBPetMangerContext context)
        {
            SeedPetsData(context);
            base.Seed(context);
        }

        private void SeedPetsData(DBPetMangerContext context)
        {
            List<PetOwner> owners = new List<PetOwner>
            {
                new PetOwner() {City="Warszawa", Name="Bolek", Surname="Bombowy",UserID=1,UserName="Bolek88"},
                new PetOwner() {City="Ząbki", Name="Lolek", Surname="Bagno",UserID=2 , UserName="Lewy1"},
                new PetOwner() {City="Zielonka", Name="Robert", Surname="Trąba",UserID=3, UserName="PrawyINiemrawy" },
                new PetOwner() {City="Łochów", Name="Melchior", Surname="Małowiejski",UserID=4,UserName="Yoyo44" },
                new PetOwner() {City="Wyszków", Name="Baltazar", Surname="Dzy-Dzy",UserID=5, UserName="Adamo666"  },
                new PetOwner() {City="Otwock", Name="Maurycy", Surname="Krewki",UserID=6 ,UserName="Bambi" },
                new PetOwner() {City="Pruszków", Name="Milosz", Surname="Nielot",UserID=7,UserName="Kubek12"},
                new PetOwner() {City="Piastów", Name="Kuba", Surname="Kura",UserID=8 , UserName="Kuras"},
                new PetOwner() {City="Piaseczno", Name="Adam", Surname="Lotnik",UserID=9, UserName="KillBill" }
            };
            owners.ForEach(c => context.Persons.Add(c));
            List<Dog> dogs = new List<Dog>
            {
                new Dog() {Name="Burek", Age=5,Breed=DogBreed.Boxer},
                new Dog() {Name="Merdek",Age= 1,Breed= DogBreed.CockerSpaniel},
                new Dog() {Name="Kłapouchy",Age= 2,Breed= DogBreed.Poodle},
                new Dog() {Name="Strażnik",Age= 15,Breed= DogBreed.Terrier},
                new Dog() {Name="Łapacz",Age= 10,Breed= DogBreed.Dalmatian},
                //new Cat() {Name="Śpiewak", Age=1,Breed=CatBreed.British },
                //new Cat() {Name="Mruczek", Age=12,Breed=CatBreed.Ragdoll }

            };
            dogs.ForEach(c => context.Dogs.Add(c));
            List<Cat> cats = new List<Cat>
            {
                new Cat() {Name="Śpiewak", Age=1,Breed=CatBreed.British },
                new Cat() {Name="Mruczek", Age=12,Breed=CatBreed.Ragdoll }

            };
            cats.ForEach(c => context.Cats.Add(c));

            //List<Pet> pets= new List<Pet>
            //{
            //    //new Dog() {Name="Burek", Age=5,Breed=DogBreed.Boxer},
            //    //new Dog() {Name="Merdek",Age= 1,Breed= DogBreed.CockerSpaniel},
            //    //new Dog() {Name="Kłapouchy",Age= 2,Breed= DogBreed.Poodle},
            //    //new Dog() {Name="Strażnik",Age= 15,Breed= DogBreed.Terrier},
            //    //new Dog() {Name="Łapacz",Age= 10,Breed= DogBreed.Dalmatian},
            //    //new Cat() {Name="Śpiewak", Age=1,Breed=CatBreed.British },
            //    //new Cat() {Name="Mruczek", Age=12,Breed=CatBreed.Ragdoll }
               
            //};
            //pets.ForEach(c => context.Pets.Add(c));

            context.SaveChanges();

        }
    }
}