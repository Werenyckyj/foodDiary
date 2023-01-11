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
    public partial class FoodPage : ContentPage
    {
        public List<Foods> Food { get { return Count.todayEated; } }
        public FoodPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new ViewModels.ListViewModel();
            today.ItemsSource = Count.todayEated;
            calor.Text = Count.Calory.ToString();
            calorProgress.Progress = Count.Calory / 2440;
            carbo.Text = Count.Carbohydrates.ToString();
            protProgress.Progress = Count.Proteins / 2300;
            prot.Text = Count.Proteins.ToString();
            carboProgress.Progress = Count.Carbohydrates / 670;
            fats.Text = Count.Fats.ToString();
            fatsProgress.Progress = Count.Fats / 70;
            today.ItemsSource = await App.Database.GetFoodAsync();
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
            await Navigation.PushAsync(new AddFood());
        }
    }
}