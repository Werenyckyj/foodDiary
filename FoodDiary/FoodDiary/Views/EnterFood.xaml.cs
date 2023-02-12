using FoodDiary.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDiary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterFood : ContentPage
    {
        public Foods Food { get; set; }
        public EnterFood(Foods f)
        {
            InitializeComponent();
            name.Text = f.Name;
            Food = f;
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
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

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(input.Text))
            {
                App.Database.AddNewEatedAsync(new DailyInfo
                {
                    Name = Food.Name,
                    Calory = Food.Calory,
                    Carbohydrates = Food.Carbohydrates,
                    Proteins = Food.Proteins,
                    Fats = Food.Fats,
                    Liquid = Food.Liquid,
                    Amount = Convert.ToDouble(input.Text)
                });
                App.Database.SaveEternaly(new AllOverInfo
                {
                    Name = Food.Name,
                    Calory = Food.Calory,
                    Carbohydrates = Food.Carbohydrates,
                    Proteins = Food.Proteins,
                    Fats = Food.Fats,
                    Liquid = Food.Liquid,
                    Amount = Convert.ToDouble(input.Text),
                    Date = DateTime.Today,
                    IsSport = false
                });
            }
            await Navigation.PopAsync();
        }
    }
}