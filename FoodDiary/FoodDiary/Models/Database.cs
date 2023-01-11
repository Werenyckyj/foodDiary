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
}
