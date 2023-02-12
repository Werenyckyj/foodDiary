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
    public partial class ViewSport : ContentPage
    {
        public Sport S { get; set; }
        public ViewSport(Sport s)
        {
            InitializeComponent();
            S = s;
            nameOfSport.Text = s.Name;
            start.Text = s.StartTime;
            end.Text = s.EndTime;
            note.Text = s.Note;
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}