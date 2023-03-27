using SQLite;
using System;
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
            database.CreateTableAsync<Sport>();
            database.CreateTableAsync<AllOverInfo>();
            database.CreateTableAsync<DateTody>();
        }
        public void InsertDefaultDatabase()
        {
            List<Foods> f = new List<Foods>();
            try
            {
                f = GetFoodAsync().Result;
            }
            catch (Exception)
            {
                if (f.Count == 0)
                {
                    FillDatabase.InsertDefault(database);
                }
            }
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
        internal void SaveSoprtAsync(Sport sport)
        {
            database.InsertAsync(sport);
        }
        public void SaveEternaly(AllOverInfo allOverInfo)
        {
            database.InsertAsync(allOverInfo);
        }
        public void SaveTheDay(DateTime today)
        {
            database.DeleteAllAsync<DateTody>();
            database.InsertAsync(new DateTody { d = today});
        }
        public Task<List<AllOverInfo>> GetAllOverInfo()
        {
            Task<List<AllOverInfo>> d = database.Table<AllOverInfo>().ToListAsync();
            return d;
        }
        public Task<List<Sport>> GetTodaySportsAsync()
        {
            Task<List<Sport>> d = database.Table<Sport>().ToListAsync();
            return d;
        }
        public Task<List<DailyInfo>> GetTodayFoodAsync()
        {
            Task<List<DailyInfo>> d = database.Table<DailyInfo>().ToListAsync();
            return d;
        }
        public Task<List<DateTody>> GetTheDay()
        {
            Task<List<DateTody>> d = database.Table<DateTody>().ToListAsync();
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
        public void DeleteToday()
        {
            database.DeleteAllAsync<DailyInfo>();
            database.DeleteAllAsync<Sport>();
        }
    }
}
