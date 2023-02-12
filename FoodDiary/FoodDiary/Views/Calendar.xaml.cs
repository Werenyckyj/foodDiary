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
    public partial class Calendar : ContentPage
    {
        public Calendar()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CountAll.CountFood(DateTime.Today);
            BindingContext = new ViewModels.ListViewModel();
            calor.Text = CountAll.Calory.ToString();
            carbo.Text = CountAll.Carbohydrates.ToString();
            prote.Text = CountAll.Proteins.ToString();
            fats.Text = CountAll.Fats.ToString();
            eatedToday.ItemsSource = CountAll.todayEated;
            water.Text = CountAll.CountLiquid().ToString();
            sportsToday.ItemsSource = CountAll.todaySports;
        }

        private async void btBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btQ_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionMark());
        }

        private void calendar_OnCalendarTapped(object sender, Syncfusion.SfCalendar.XForms.CalendarTappedEventArgs e)
        {
            CountAll.CountFood(calendar.SelectedDate);
            BindingContext = new ViewModels.ListViewModel();
            calor.Text = CountAll.Calory.ToString();
            carbo.Text = CountAll.Carbohydrates.ToString();
            prote.Text = CountAll.Proteins.ToString();
            fats.Text = CountAll.Fats.ToString();
            eatedToday.ItemsSource = CountAll.todayEated;
            water.Text = CountAll.CountLiquid().ToString();
            sportsToday.ItemsSource = CountAll.todaySports;
        }
    }
}