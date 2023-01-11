using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodDiary.Models
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Foods>();
        }
        public Task<List<Foods>> GetFoodAsync()
        {
            return _database.Table<Foods>().ToListAsync();
        }
        public Task<int> SaveFoodAsync(Foods food)
        {
            return _database.InsertAsync(food);
        }
    }
    public class DailyDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public DailyDatabase(string ddbPath)
        {
            _database = new SQLiteAsyncConnection(ddbPath);
            _database.CreateTableAsync<DailyInfo>();
        }
        public Task<int> AddNewEatedAsync(DailyInfo dailyInfo)
        {
            return _database.InsertAsync(dailyInfo);
        }
        public Task<List<Foods>> GetTodayFoodAsync()
        {
            List<DailyInfo> todayEated = _database.Table<DailyInfo>().ToListAsync();
            List<Foods> todayFood = new List<Foods>();
            foreach (var item in todayEated)
            {
                todayFood.Add(item.TodayFood);
            }
            return todayFood;
        }
    }
}
