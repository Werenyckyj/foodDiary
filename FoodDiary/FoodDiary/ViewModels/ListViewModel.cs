using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FoodDiary.ViewModels
{
    class ListViewModel : BindableObject
    {
        public ObservableCollection<Foods> _Foods { get; set; }
        public ObservableCollection<Foods> Foods
        {
            get
            {
                return _Foods;
            }
            set
            {
                _Foods = value;
                OnPropertyChanged();
            }
        }
        public ListViewModel()
        {
            Foods = new ObservableCollection<Foods>()
            {
                new Foods(){},
            };
            
        }
    }
}
