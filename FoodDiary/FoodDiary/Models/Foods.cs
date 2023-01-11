using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FoodDiary.Models
{
    public class Foods
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Calory { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats { get; set; }
        public int Proteins { get; set; }
    }
}
