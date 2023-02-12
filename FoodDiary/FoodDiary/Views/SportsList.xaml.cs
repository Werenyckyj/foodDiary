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
    public partial class SportsList : ContentPage
    {
        public SportsList()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CountSports.CountSport();
            BindingContext = new ViewModels.ListViewModel();
            sportToday.ItemsSource = CountSports.todaySported;
        }
        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private async void AddNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSport());
        }

        private async void sportToday_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var sport = e.Item as Sport;

            await this.Navigation.PushAsync(new ViewSport(sport), false);

            ((ListView)sender).SelectedItem = null;
        }
    }
}