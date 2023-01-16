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
        public double Amount { get; set; }
        public string Name { get; set; }
        public double Calory { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
        public bool Liquid { get; set; }
    }
}
