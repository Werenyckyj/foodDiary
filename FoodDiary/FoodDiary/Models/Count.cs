using FoodDiary.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Models
{
    public static class Count
    {
        public static List<Foods> todayEated = new List<Foods>();
        public static double Calory { get; set; }
        public static double Carbohydrates { get; set; }
        public static double Fats { get; set; }
        public static double Proteins { get; set; }
        public async static void CountFood()
        {
            List<DailyInfo> dailyInfo = await App.Database.GetTodayFoodAsync();
            foreach (var food in dailyInfo)
            {
                todayEated.Add(food.TodayFood);
                Calory +=  food.TodayFood.Calory / 100 * food.Amount;
                Carbohydrates += food.TodayFood.Carbohydrates / 100 * food.Amount;
                Fats += food.TodayFood.Fats / 100 * food.Amount;
                Proteins += food.TodayFood.Proteins / 100 * food.Amount;
            }
        }
    }
}
