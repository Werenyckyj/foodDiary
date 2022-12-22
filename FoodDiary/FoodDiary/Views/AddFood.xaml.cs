using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Foods
    {
        public string Name { get; set; }
    }
    public partial class AddFood : ContentPage
    {
        List<Foods> collectionOfFood = new List<Foods>();
        public List<Foods> Food { get { return collectionOfFood; } }
        public AddFood()
        {
            InitializeComponent();
            FoodView.ItemsSource = collectionOfFood;
            collectionOfFood.Add(new Foods { Name = "Rohlík" });
            collectionOfFood.Add(new Foods { Name = "Houska" });
            collectionOfFood.Add(new Foods { Name = "Chleba" });
        }

        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btQ_Clicked(object sender, EventArgs e)
        {

        }
    }
}