using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDiary.Models;
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
            var n = new FoodPage();
            Count.todayEated.Add(Food);
            Count.CountFood();
            await Navigation.PopAsync();
            n.Out();
        }
    }
}