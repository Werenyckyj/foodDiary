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
    public partial class Modifi : ContentPage
    {
        public Foods F { get; set; }
        public Modifi(Foods f)
        {
            InitializeComponent();
            F = f;
            name.Text = F.Name;
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (inputCal.Text != "")
            {
                F.Calory = Convert.ToDouble(inputCal.Text);
            }
            if (inputCar.Text != "")
            {
                F.Carbohydrates = Convert.ToDouble(inputCar.Text);
            }
            if (inputPro.Text != "")
            {
                F.Proteins = Convert.ToDouble(inputPro.Text);
            }
            if (inputFat.Text != "")
            {
                F.Fats = Convert.ToDouble(inputPro.Text);
            }
            App.Database.EditData(F);

            await Navigation.PopAsync();
        }
    }
}