using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            await Navigation.PushAsync(new Views.FoodPage());
        }

        private async void btAddFood_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ModifiList());
        }
    }
}
