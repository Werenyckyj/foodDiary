using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddWater : ContentPage
    {
        public AddWater()
        {
            InitializeComponent();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(input.Text))
            {
                App.Database.AddNewEatedAsync(new DailyInfo
                {
                    Name = "Water",
                    Liquid = true,
                    Amount = Convert.ToDouble(input.Text)
                });
            }
            await Navigation.PopAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}