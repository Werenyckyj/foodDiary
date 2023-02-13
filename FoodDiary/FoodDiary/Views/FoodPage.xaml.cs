using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage : ContentPage
    {
        public ObservableCollection<Foods> Food { get { return Count.todayEated; } }
        public FoodPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Count.CountFood();
            BindingContext = new ViewModels.ListViewModel();
            List<Foods> f = new List<Foods>();
            today.ItemsSource = Count.todayEated;
            calor.Text = Count.Calory.ToString();
            calorProgress.Progress = Count.Calory / 2440;
            carbo.Text = Count.Carbohydrates.ToString();
            protProgress.Progress = Count.Proteins / 80;
            prot.Text = Count.Proteins.ToString();
            carboProgress.Progress = Count.Carbohydrates / 670;
            fats.Text = Count.Fats.ToString();
            fatsProgress.Progress = Count.Fats / 70;
        }
        public void Updater()
        {
            OnAppearing();
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