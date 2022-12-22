using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage = new NavigationPage(new Views.FoodPage());
            MainPage = new NavigationPage(new FoodDiary.MainPage());

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
