using FoodDiary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodDiary.ViewModels
{
    class ListViewModel
    {
        public ObservableCollection<ListModel> Food { get; set; }
        public ListViewModel()
        {
            Food = new ObservableCollection<ListModel>()
            {
                new ListModel(){},
            };
        }
    }
}
