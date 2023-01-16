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
    public partial class ModifiList : ContentPage
    {
        public ModifiList()
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

            await this.Navigation.PushAsync(new Modifi(food), false);

            ((ListView)sender).SelectedItem = null;
        }

        private async void AddNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Add());
        }
    }
}