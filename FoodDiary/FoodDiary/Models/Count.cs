using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FoodDiary.Models
{
    public static class Count
    {
        public static ObservableCollection<Foods> todayEated = new ObservableCollection<Foods>();
        public static ObservableCollection<Foods> todayDrenk = new ObservableCollection<Foods>();
        public static double Calory { get; set; }
        public static double CaloryProgress { get; set; }
        public static double Carbohydrates { get; set; }
        public static double CarboProgress { get; set; }
        public static double Fats { get; set; }
        public static double FatsProgress { get; set; }
        public static double Proteins { get; set; }
        public static double ProtProgress { get; set; }
        public async static void CountFood()
        {
            List<DailyInfo> dailyInfo = new List<DailyInfo>();
            //ObservableCollection<DailyInfo> dailyInfo = new ObservableCollection<DailyInfo>(dailyInfos);
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
                        Name = "Voda",
                        Amount = food.Amount
                    });
                    continue;
                }
                if (food.Liquid == true)
                {
                    todayDrenk.Add(new Foods
                    {
                        Name = food.Name,
                        Amount = food.Amount
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
                CaloryProgress = Calory/ 2440;
                CarboProgress = Carbohydrates / 670;
                FatsProgress = Fats / 70;
                ProtProgress = Proteins / 80;
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
