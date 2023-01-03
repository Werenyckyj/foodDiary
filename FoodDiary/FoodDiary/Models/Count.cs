using FoodDiary.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Models
{
    public static class Count
    {
        public static List<Foods> todayEated = new List<Foods>();
        public static int Calory { get; set; }
        public static int Carbohydrates { get; set; }
        public static int Fats { get; set; }
        public static int Proteins { get; set; }
        public static void CountFood()
        {
            Calory += todayEated[todayEated.Count - 1].Calory;
            Carbohydrates += todayEated[todayEated.Count - 1].Carbohydrates;
            Fats += todayEated[todayEated.Count - 1].Fats;
            Proteins += todayEated[todayEated.Count - 1].Proteins;
        }
    }
}
