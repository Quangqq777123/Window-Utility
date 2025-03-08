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
    /*
     * class wrapper Datetime
     * có các chức năng hỗ trợ tính toán ngày tháng
     * dựa trên struct DateTime có sẵn 
     */
    internal class CustomTime
    {
        private DateTime time;
        ///constructor
        public CustomTime()
        {
            this.time = new DateTime();
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

        ///methods
        private static Tuple<int, int, int, int, int, int, int> timeNormalize(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            /*
             hàm chuẩn hóa thời gian,
             chỉ sử dụng 1 lần cho việc khởi tạo bằng constructor
             sau này việc chuẩn hóa sẽ tự động nhờ hàm add có sẵn của struct DateTime
             */
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
        public override string ToString()
        {
            return this.time.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        public double getDifferenceDays(DateTime newTime)
        {
            return newTime.Subtract(this.time).TotalDays;
        }
        public double getDifferenceHours(DateTime newTime)
        {
            return newTime.Subtract(this.time).TotalHours;
        }
        public double getDifferenceMinutes(DateTime newTime)
        {
            return newTime.Subtract(this.time).TotalMinutes;
        }
        public double getDifferenceSeconds(DateTime newTime)
        {
           return newTime.Subtract(this.time).TotalSeconds;
        }
        public double getDifferenceMilliseconds(DateTime newTime)
        {
            return newTime.Subtract(this.time).TotalMilliseconds;
        }
        ///getter and setter
        public DateTime Time
        {
            get { return this.time; }
            set { time = value; }
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
        public void setHour(int hour)
        {
            this.time.AddHours(hour);
        }
        public int getHour()
        {
            return this.time.Hour;
        }
        public void setMinute(int minute)
        {
            this.time.AddMinutes(minute);
        }
        public int getMinute()
        {
            return this.time.Minute;
        }
        public void setSecond(int second)
        {
            this.time.AddSeconds(second);
        }
        public int getSecond()
        {
            return this.time.Second;
        }
        public void setMillisecond(int millisecond)
        {
            this.time.AddMilliseconds(millisecond);
        }
        public int getMillisecond()
        {
            return this.time.Millisecond;
        }
    }

}
