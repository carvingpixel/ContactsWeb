namespace ContactsWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactsWeb.Models.ContactsWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ContactsWeb.Models.ContactsWebContext";
        }

        protected override void Seed(ContactsWeb.Models.ContactsWebContext context)
        {


            //   

            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact
                {

                    Id = 1,
                    Birthdate = new DateTime(1920, 01, 20),
                    City = "Chicago"
                    ,
                    Email = "doc.mccoy@starfleet.com",
                    FirstName = "DeForest",
                    LastName = "Kelley"
                    ,
                    PhonePrimary = "123-456-7890",
                    PhoneSecondary = "234-567-8901",
                    state = "IL"
                    ,
                    StreetAdd = "Sickbay",
                    StreetAdd2 = "Starship Enterprise NCC-1701"
                    ,
                    UserId = new Guid("3d8a2fdc-56e8-41b5-9952-57752058b55f")
                    ,
                    zip = "98765"
                }
                , new Models.Contact
                {
                    Id = 2,
                    Birthdate = new DateTime(1920, 03, 03),
                    City = "New York"
                    ,
                    Email = "i.beam.you.up@starfleet.com",
                    FirstName = "James",
                    LastName = "Doohan"
                    ,
                    PhonePrimary = "345-678-9012",
                    PhoneSecondary = "456-789-0123",
                    state = "NY"
                    ,
                    StreetAdd = "Engineering",
                    StreetAdd2 = "Starship Enterprise NCC-1701"
                    ,
                    UserId = new Guid("3d8a2fdc-56e8-41b5-9952-57752058b55f")
                    ,
                    zip = "87654"
                }
                , new Models.Contact
                {
                    Id = 3,
                    Birthdate = new DateTime(1931, 03, 26),
                    City = "Los Angeles"
                    ,
                    Email = "its.only.logic@starfleet.com",
                    FirstName = "Leonard",
                    LastName = "Nimoy"
                    ,
                    PhonePrimary = "987-654-3210",
                    PhoneSecondary = "876-543-2109",
                    state = "CA"
                    ,
                    StreetAdd = "Science Station 1",
                    StreetAdd2 = "Starship Enterprise NCC-1701"
                    ,
                    UserId = new Guid("3d8a2fdc-56e8-41b5-9952-57752058b55f")
                    ,
                    zip = "76543-2109"
                }
                , new Models.Contact
                {
                    Id = 4,
                    Birthdate = new DateTime(1931, 03, 22),
                    City = "Riverside"
                    ,
                    Email = "the.captain@starfleet.com",
                    FirstName = "William",
                    LastName = "Shatner"
                    ,
                    PhonePrimary = "765-432-1098",
                    PhoneSecondary = "654-321-0987",
                    state = "IA"
                    ,
                    StreetAdd = "The Bridge",
                    StreetAdd2 = "Starship Enterprise NCC-1701"
                    ,
                    UserId = new Guid("3d8a2fdc-4444-41b5-9952-57752058b55f")
                    ,
                    zip = "65432-0123"
                }
            );
        }
    }
}
