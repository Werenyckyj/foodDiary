﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Models
{
    class CountSports
    {
        public static List<Sport> todaySported = new List<Sport>();
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
                todaySported.Add(new Sport
                {
                    Name = item.Name,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime,
                    Note = item.Note
                });
            }
        }
    }
}