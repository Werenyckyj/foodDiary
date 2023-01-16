using System.Collections.Generic;

namespace FoodDiary.Models
{
    public static class Count
    {
        public static List<Foods> todayEated = new List<Foods>();
        public static List<Foods> todayDrenk = new List<Foods>();
        public static double Calory { get; set; }
        public static double Carbohydrates { get; set; }
        public static double Fats { get; set; }
        public static double Proteins { get; set; }
        public async static void CountFood()
        {
            List<DailyInfo> dailyInfo = new List<DailyInfo>();
            try
            {
                dailyInfo = await App.Database.GetTodayFoodAsync();
            }
            catch (System.Exception)
            {
            }
            todayEated.Clear();
            todayDrenk.Clear();
            Calory = 0;
            Carbohydrates = 0;
            Fats = 0;
            Proteins = 0;
            foreach (var food in dailyInfo)
            {
                if (food.Name == "Water")
                {
                    todayDrenk.Add(new Foods
                    {
                        Name = "Voda"
                    });
                    continue;
                }
                if (food.Liquid == true)
                {
                    todayDrenk.Add(new Foods
                    {
                        Name = food.Name
                    });
                }
                todayEated.Add(new Foods
                {
                    Name = food.Name,
                    Calory = food.Calory / 100 * food.Amount,
                    Carbohydrates = food.Carbohydrates / 100 * food.Amount,
                    Proteins = food.Proteins / 100 * food.Amount,
                    Fats = food.Fats / 100 * food.Amount
                });
                Calory += food.Calory / 100 * food.Amount;
                Carbohydrates += food.Carbohydrates / 100 * food.Amount;
                Fats += food.Fats / 100 * food.Amount;
                Proteins += food.Proteins / 100 * food.Amount;
            }
        }
    }
}
