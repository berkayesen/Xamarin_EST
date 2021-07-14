using ProjectXamarin.Services;
using ProjectXamarin.Views;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin
{
    public partial class App : Application
    {
        //private static ProductDatabase database;
        //private static string FolderPath { get; set; }

        //public static ProductDatabase Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new ProductDatabase(Path.Combine(App.FolderPath, "ProductsDb.db3"));
        //        }
        //        return database;
        //    }
        //}

        public App()
        {
            InitializeComponent();


            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MainPage = new LoginView();
            MainPage = new AppShell();
            //MainPage = new Filtreleme();
            //MainPage = new HawaiAnanasKolonyasi();
            //MainPage = new Settings();

            //string uname = Preferences.Get("UserName", String.Empty);
            //if (String.IsNullOrEmpty(uname))
            //{
            //    MainPage = new LoginView();
            //}
            //else
            //{
            //    MainPage = new FirstPage();
            //}

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
