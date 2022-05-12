using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
    public partial class App : Application
    {
        public static string FilePath;

        public App()
        {
            InitializeComponent();

            // This defines the contacts page as the navigation page
            // and sets it as the MainPage (start screen)
            // The NavigationPage means that a "Back" button will automatically
            // be added when we navigate *away* from the ContactsPage()
            MainPage = new NavigationPage(new ContactsPage());
        }

        public App(string filePath)
        {
            // This is used to get the file-path for saving data in Android

            InitializeComponent();

            // This defines the contacts page as the navigation page
            // and sets it as the MainPage (start screen)
            // The NavigationPage means that a "Back" button will automatically
            // be added when we navigate *away* from the ContactsPage()
            MainPage = new NavigationPage(new ContactsPage());

            // Setting up the file path
            FilePath = filePath;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
