using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FoodDiary.Models
{
    [Table("AllOverInfo")]
    public class AllOverInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Calory { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
        public bool Liquid { get; set; }
        public double Amount { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Note { get; set; }
        public bool IsSport { get; set; }
        public DateTime Date { get; set; }
    }
}
