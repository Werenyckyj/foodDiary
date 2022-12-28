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
    public partial class FoodPage : ContentPage
    {
        public List<Foods> Food { get { return Count.todayEated; } }
        public FoodPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewModel();
            today.ItemsSource = Count.todayEated;
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
        public void Out()
        {
            Food.Add(Count.todayEated[Count.todayEated.Count-1]);
            cal.Text = Count.Calory.ToString();
        }
    }
}