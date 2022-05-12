using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Contacts.Classes;
using SQLite;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            /* 
             * Defines what happens when the main page's "Save" button (called "btnSave") is clicked
             */
            Contact contact = new Contact()
            {
                // Creating a new Contact class with the following properties
                Name = nameEntry.Text,
                Lastname = lastnameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Address = addressEntry.Text,
            };

            // Here we connect to the filepath that we defined for iOS and Android
            // This connection ONLY exists for this code block
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Contact>();            // Creating the Contact table
                int rowsAdded = conn.Insert(contact);   // Inserting the new contact into the table
            }

        }
    }
}
