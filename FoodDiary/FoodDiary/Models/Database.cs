﻿using SQLite;
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
            FillDatabase.InsertDefault(database);
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
