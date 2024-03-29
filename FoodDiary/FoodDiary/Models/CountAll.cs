﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodDiary.Models
{
    public static class CountAll
    {
        public static ObservableCollection<Foods> todayEated = new ObservableCollection<Foods>();
        public static ObservableCollection<Foods> todayDrenk = new ObservableCollection<Foods>();
        public static ObservableCollection<Sport> todaySports = new ObservableCollection<Sport>();
        public static double Calory { get; set; }
        public static double Carbohydrates { get; set; }
        public static double Fats { get; set; }
        public static double Proteins { get; set; }
        public async static void CountFood(DateTime? selectedDate)
        {
            List<AllOverInfo> dailyInfo = new List<AllOverInfo>();
            try
            {
                dailyInfo = await App.Database.GetAllOverInfo();
            }
            catch (System.Exception)
            {
            }
            todayEated.Clear();
            todayDrenk.Clear();
            todaySports.Clear();
            Calory = 0;
            Carbohydrates = 0;
            Fats = 0;
            Proteins = 0;
            foreach (var item in dailyInfo)
            {
                if (selectedDate == item.Date)
                {
                    if (item.Name == "Water")
                    {
                        todayDrenk.Add(new Foods
                        {
                            Name = "Voda",
                            Amount = item.Amount
                        });
                        continue;
                    }
                    if (item.IsSport == true)
                    {
                        DateTime startt = Convert.ToDateTime(item.StartTime);
                        DateTime endd = Convert.ToDateTime(item.EndTime);
                        todaySports.Add(new Sport
                        {
                            Name = item.Name,
                            StartTime = startt.ToString("HH:mm"),
                            EndTime = endd.ToString("HH:mm"),
                            Note = item.Note
                        });
                        continue;
                    }
                    if (item.Liquid == true)
                    {
                        todayDrenk.Add(new Foods
                        {
                            Name = item.Name,
                            Amount = item.Amount
                        });
                    }
                    todayEated.Add(new Foods
                    {
                        Name = item.Name,
                        Calory = item.Calory / 100 * item.Amount,
                        Carbohydrates = item.Carbohydrates / 100 * item.Amount,
                        Proteins = item.Proteins / 100 * item.Amount,
                        Fats = item.Fats / 100 * item.Amount
                    });
                    Calory += item.Calory / 100 * item.Amount;
                    Carbohydrates += item.Carbohydrates / 100 * item.Amount;
                    Fats += item.Fats / 100 * item.Amount;
                    Proteins += item.Proteins / 100 * item.Amount;
                }
            }
        }
        public static double CountLiquid()
        {
            double total = 0;
            foreach (var item in todayDrenk)
            {
                total += item.Amount;
            }
            return total;
        }
    }
}
