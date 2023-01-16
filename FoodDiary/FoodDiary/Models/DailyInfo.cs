using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Models
{
    [Table("DailyInfo")]
    public class DailyInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public Foods TodayFood { get; set; }
        public double Amount { get; set; }
    }
}
