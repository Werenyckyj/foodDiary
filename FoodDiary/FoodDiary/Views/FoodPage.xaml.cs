using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage : ContentPage
    {
        public string Calory { get; set; }
        public string Carbohydrates { get; set; }
        public string Proteins { get; set; }
        public string Fats { get; set; }

        public ObservableCollection<Foods> Food { get { return Count.todayEated; } }
        public FoodPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Count.CountFood();
            BindingContext = new ViewModels.ListViewModel();
            today.ItemsSource = Count.todayEated;
            Calory = Count.Calory.ToString();
            calor.Text = Count.Calory.ToString();
            calorProgress.Progress = Count.CaloryProgress;
            Carbohydrates = Count.Carbohydrates.ToString();
            carbo.Text = Count.Calory.ToString();
            protProgress.Progress = Count.ProtProgress;
            Proteins = Count.Proteins.ToString();
            prot.Text = Count.Calory.ToString();
            carboProgress.Progress = Count.CarboProgress;
            Fats = Count.Fats.ToString();
            fats.Text = Count.Calory.ToString();
            fatsProgress.Progress = Count.FatsProgress;
            base.OnAppearing();
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