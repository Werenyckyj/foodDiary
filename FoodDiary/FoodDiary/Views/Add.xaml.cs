using FoodDiary.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private void inputCal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputCal.Text) && !string.IsNullOrWhiteSpace(inputCar.Text) && !string.IsNullOrWhiteSpace(inputFat.Text) && !string.IsNullOrWhiteSpace(inputPro.Text) && !string.IsNullOrWhiteSpace(name.Text) && type.SelectedItem != null)
            {
                bool l = true;
                if (type.SelectedIndex == 0)
                {
                    l = false;
                }
                App.Database.SaveFoodAsync(new Foods
                {
                    Name = name.Text,
                    Calory = int.Parse(inputCal.Text),
                    Carbohydrates = int.Parse(inputCar.Text),
                    Proteins = int.Parse(inputPro.Text),
                    Fats = int.Parse(inputFat.Text),
                    Liquid = l
                });
            }
            await Navigation.PopAsync();
        }
    }
}