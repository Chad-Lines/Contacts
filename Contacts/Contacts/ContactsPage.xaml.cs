using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Classes;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private void btnNewContact_Clicked(object sender, EventArgs e)
        {
            // When the NEW button is clicked, navigate to the MainPage
            Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            // Every time the Contacts Page is displayed, this code will run

            base.OnAppearing();         // Inheriting from the base class

            // Connecting to the SQLite database 
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                // Keep in mind that, with SQLite, if you try to create a table that already
                // exists, it simply ignores the execution. That's why we can "create" this
                // table in multiple places (as a fail-safe) without creating redundant 
                // tables.
                conn.CreateTable<Contact>();                    // Creating the Database
                var contacts = conn.Table<Contact>().ToList();  // Converting the database table into a list

            }
            
        }
    }
}