using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FoodDiary.Models;
using SQLite;
using Xamarin.Forms;

namespace FoodDiary.Models
{
    [Table("Foods")]
    public class Foods
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
    }
}
