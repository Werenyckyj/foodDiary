using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodDiary.Models
{
    class CountSports
    {
        public static ObservableCollection<Sport> todaySported = new ObservableCollection<Sport>();
        public async static void CountSport()
        {
            List<Sport> sports = new List<Sport>();
            try
            {
                sports = await App.Database.GetTodaySportsAsync();
            }
            catch (System.Exception)
            {
            }
            todaySported.Clear();
            foreach (var item in sports)
            {
                DateTime startt = Convert.ToDateTime(item.StartTime);
                DateTime endd = Convert.ToDateTime(item.EndTime);
                todaySported.Add(new Sport
                {
                    Name = item.Name,
                    StartTime = startt.ToString("HH:mm"),
                    EndTime = endd.ToString("HH:mm"),
                    Note = item.Note
                });
            }
        }
    }
}
