using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodDiary.Models;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AddFood : ContentPage
    {
        public AddFood()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            FoodView.ItemsSource = await App.Database.GetFoodAsync();
        }
        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private async void FoodView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var food = e.Item as Foods;

            await this.Navigation.PushAsync(new EnterFood(food), false);

            ((ListView)sender).SelectedItem = null;
        }
    }
}