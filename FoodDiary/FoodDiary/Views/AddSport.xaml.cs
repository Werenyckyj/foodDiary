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
    public partial class AddSport : ContentPage
    {
        public AddSport()
        {
            InitializeComponent();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputName.Text))
            {
                App.Database.SaveSoprtAsync(new Sport
                {
                    Name = inputName.Text,
                    StartTime = inputSTime.Time.ToString(),
                    EndTime = inputETime.Time.ToString(),
                    Note = note.Text
                });
                App.Database.SaveEternaly(new AllOverInfo
                {
                    Name = inputName.Text,
                    StartTime = inputSTime.Time.ToString(),
                    EndTime = inputETime.Time.ToString(),
                    Note = note.Text,
                    IsSport = true,
                    Date = DateTime.Today
                });
            }
            await Navigation.PopAsync();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}