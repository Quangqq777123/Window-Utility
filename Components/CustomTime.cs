using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowUtility
{
    internal class CustomTime
    {
        private DateTime time;
        public DateTime Time
        {
            get { return this.time; }
            set { time = value; }
        }        
        public CustomTime()
        {
            this.time = new DateTime();
        }

        private static Tuple<int,int,int,int,int,int,int> timeNormalize(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            second += millisecond / 1000;
            millisecond %= 1000;
            minute += second / 60;
            second %= 60;
            hour += minute / 60;
            minute %= 60;
            day += hour / 24;
            hour %= 24;

            while (true)
            {
                int daysInMonth = DateTime.DaysInMonth(year, month);
                if (day <= daysInMonth)
                    break;

                day -= daysInMonth;
                month++;

                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }

            return Tuple.Create(year, month, day, hour, minute, second, millisecond);
        }

        public CustomTime(int year, int month, int day, int hour, int minute, int second, int millisecond )
        {
            Tuple<int,int,int,int,int,int,int> timeNormalized = timeNormalize(year, month, day, hour, minute, second, millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2,timeNormalized.Item3,timeNormalized.Item4,timeNormalized.Item5,timeNormalized.Item6,timeNormalized.Item7);
        }

        public CustomTime(int year, int month, int day, int hour, int minute, int second)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(year, month, day, hour, minute, second, 0);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);

        }

        public CustomTime(int hour, int minute, int second, int millisecond) {
            DateTime now = DateTime.Now;
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(now.Year, now.Month, now.Day, hour, minute, second, millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public CustomTime(int hour, int minute, int second)
        {
            DateTime now = DateTime.Now;
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(now.Year, now.Month, now.Day, hour, minute, second, 0);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }

        public void now()
        {
            try
            {
                this.time = DateTime.Now;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }

        public void setYear(int year)
        {
            this.time.AddYears(year);
        }

        public int getYear()
        {
            return this.time.Year;
        }

        public void setMonth(int month)
        {
            this.time.AddMonths(month);
        }

        public int getMonth()
        {
            return this.time.Month;
        }

        public void setDay(int day)
        {
            this.time.AddMonths(day);
        }

        public int getDay()
        {
            return this.time.Day;
        }
        

    }

}
