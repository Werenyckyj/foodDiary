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
        public static void CountFood(double exp)
        {
            Calory += todayEated[todayEated.Count - 1].Calory / 100 * exp;
            Carbohydrates += todayEated[todayEated.Count - 1].Carbohydrates / 100 * exp;
            Fats += todayEated[todayEated.Count - 1].Fats / 100 * exp;
            Proteins += todayEated[todayEated.Count - 1].Proteins / 100 * exp;
        }
    }
}
