using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsWeb.Models
{
    public class Contact
    {
        // props

        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhonePrimary { get; set; }
        public string PhoneSecondary { get; set; }
        public DateTime Birthdate { get; set; }
        public string StreetAdd { get; set; }
        public string StreetAdd2 { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

    }
}