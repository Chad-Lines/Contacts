using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{    
    public class Contact
    {
        // These are the columns in the Contact table

        [PrimaryKey, AutoIncrement] // These are SQLite properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        [MaxLength(10)] // Setting the max length of the field to 10
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Contact()
        {

        }
    }
}
