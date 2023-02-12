using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FoodDiary.Models
{
    [Table("Sport")]
    public class Sport
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Note { get; set; }
    }
}
