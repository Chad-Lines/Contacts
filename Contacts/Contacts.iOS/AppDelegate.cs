using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace Contacts.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // The name for the database where we're going to save user-added data
            string fileName = "Contact_db.db3";

            // Setting the path to the user's Library folder
            string folderPath = Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library");

            // Combining the folderPath and fileName to get the complete path
            string completePath = Path.Combine(folderPath, fileName);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
