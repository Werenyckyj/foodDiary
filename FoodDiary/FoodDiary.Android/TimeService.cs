using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Droid
{
    [Service]
    class TimeService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            DateTime today = DateTime.Today;
            DateTime mid = today.AddDays(1).AddSeconds(-1);
            ScheduleAction(mid);
            return null;
        }
        public async void ScheduleAction(DateTime ExecutionTime)
        {
            await Task.Delay((int)ExecutionTime.Subtract(DateTime.Now).TotalMilliseconds);
            App.Database.DeleteToday();
        }
    }
}