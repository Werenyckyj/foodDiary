using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FoodDiary.Models
{
    public class Database
    {
        private readonly SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<DailyInfo>();
            database.CreateTableAsync<Foods>();
        }
        public Task<List<Foods>> GetFoodAsync()
        {
            Task<List<Foods>> d = database.Table<Foods>().ToListAsync();
            return d;
        }
        public void SaveFoodAsync(Foods food)
        {
            database.InsertAsync(food);
        }
        public Task<List<DailyInfo>> GetTodayFoodAsync()
        {
            Task<List<DailyInfo>> d = database.Table<DailyInfo>().ToListAsync();
            return d;
        }
        public void AddNewEatedAsync(DailyInfo dailyInfo)
        {
            database.InsertAsync(dailyInfo);
        }
        public void EditData(Foods editedFood)
        {
            database.UpdateAsync(editedFood);
        }
    }
}
