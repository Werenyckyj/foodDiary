using FoodDiary.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary
{
    public partial class App : Application
    {
        private static Database database;
        private static DailyDatabase dDatabase;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "food.db3"));
                }
                return database;
            }
        }
        public static DailyDatabase DailyDatabase
        {
            get
            {
                if (dDatabase == null)
                {
                    dDatabase = new DailyDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "today.db3"));
                }
                return dDatabase;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
