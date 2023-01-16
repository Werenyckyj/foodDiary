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
            _database.CreateTableAsync<DailyInfo>();
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
        public Task<List<DailyInfo>> GetTodayFoodAsync()
        {
            return _database.Table<DailyInfo>().ToListAsync();
        }
        public Task<int> AddNewEatedAsync(DailyInfo dailyInfo)
        {
            return _database.InsertAsync(dailyInfo);
        }
    }
    public class DailyDatabase
    {
        private readonly SQLiteAsyncConnection _dDatabase;
        public DailyDatabase(string ddbPath)
        {
            _dDatabase = new SQLiteAsyncConnection(ddbPath);
            _dDatabase.CreateTableAsync<DailyInfo>();
        }


    }
}
