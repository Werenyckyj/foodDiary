﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Foods
    {
        public string Name { get; set; }
        public int Calory { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats { get; set; }
        public int Proteins { get; set; }
    }
    public partial class AddFood : ContentPage
    {
        List<Foods> collectionOfFood = new List<Foods>();
        public List<Foods> Food { get { return collectionOfFood; } }
        public AddFood()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewModel();
            FoodView.ItemsSource = collectionOfFood;
            collectionOfFood.Add(new Foods { Name = "Rohlík", Calory = 20 });
            collectionOfFood.Add(new Foods { Name = "Houska" });
            collectionOfFood.Add(new Foods { Name = "Chleba" });
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