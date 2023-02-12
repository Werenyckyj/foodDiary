using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FoodDiary.Views;

namespace FoodDiary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btFood_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodPage());
        }

        private async void btAddFood_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModifiList());
        }

        private async void btWater_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Water());
        }

        private async void btSport_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SportsList());
        }

        private async void btCalendar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar());
        }
    }
}
