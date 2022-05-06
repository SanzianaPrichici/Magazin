using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Magazin.Data;

namespace Magazin
{
    public partial class App : Application
    {
        static ClientDB database;
        public static ClientDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new ClientDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Client1.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
