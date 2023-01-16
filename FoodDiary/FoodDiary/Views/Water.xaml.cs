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
    public partial class Water : ContentPage
    {
        public Water()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Count.CountFood();
            BindingContext = new ViewModels.ListViewModel();
            waterToday.ItemsSource = Count.todayDrenk;
        }
        private async  void AddNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddWater());
        }

        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }
    }
}