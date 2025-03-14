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
            this.time = DateTime.Now;
        }
        public CustomTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(year, month, day, hour, minute, second, millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
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
            this.time = DateTime.Now;
        }
        public override string ToString()
        {
            return this.time.ToString("dd-MM-yyyy HH:mm:ss.fff");
        }
        public double getDifferenceDays(CustomTime newTime)
        {
            return this.time.Subtract(newTime.Time).TotalDays;
        }
        public double getDifferenceHours(CustomTime newTime)
        {
            return this.time.Subtract(newTime.Time).TotalHours;
        }
        public double getDifferenceMinutes(CustomTime newTime)
        {
            return this.time.Subtract(newTime.Time).TotalMinutes;
        }
        public double getDifferenceSeconds(CustomTime newTime)
        {
            return this.time.Subtract(newTime.Time).TotalSeconds;
        }
        public double getDifferenceMilliseconds(CustomTime newTime)
        {
            return this.time.Subtract(newTime.Time).TotalMilliseconds;
        }
        public void addYear(int year)
        {
            this.time = this.time.AddYears(year);
        }
        public void addMonth(int month)
        {
            this.time = this.time.AddMonths(month);
        }
        public void addDay(int day)
        {
            this.time = this.time.AddDays(day);
        }
        public void addHour(int hour)
        {
            this.time = this.time.AddHours(hour);
        }
        public void addMinute(int minute)
        {
            this.time = this.time.AddMinutes(minute);
        }
        public void addSecond(int second)
        {
            this.time = this.time.AddSeconds(second);
        }
        public void addMillisecond(int millisecond)
        {
            this.time = this.time.AddMilliseconds(millisecond);
        }
        ///getter and setter
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public void setYear(int year)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(year, this.time.Month, this.time.Day, this.time.Hour, this.time.Minute, this.time.Second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        } 
        public int getYear()
        {
            return this.time.Year;
        }
        public void setMonth(int month)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, month, this.time.Day, this.time.Hour, this.time.Minute, this.time.Second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getMonth()
        {
            return this.time.Month;
        }
        public void setDay(int day)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, this.time.Month, day, this.time.Hour, this.time.Minute, this.time.Second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getDay()
        {
            return this.time.Day;
        }
        public void setHour(int hour)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, this.time.Month, this.time.Day, hour, this.time.Minute, this.time.Second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getHour()
        {
            return this.time.Hour;
        }
        public void setMinute(int minute)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, this.time.Month, this.time.Day, this.time.Hour, minute, this.time.Second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getMinute()
        {
            return this.time.Minute;
        }
        public void setSecond(int second)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, this.time.Month, this.time.Day, this.time.Hour, this.time.Minute,second, this.time.Millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getSecond()
        {
            return this.time.Second;
        }
        public void setMillisecond(int millisecond)
        {
            Tuple<int, int, int, int, int, int, int> timeNormalized = timeNormalize(this.time.Year, this.time.Month, this.time.Day, this.time.Hour, this.time.Minute, this.time.Second, millisecond);
            this.time = new DateTime(timeNormalized.Item1, timeNormalized.Item2, timeNormalized.Item3, timeNormalized.Item4, timeNormalized.Item5, timeNormalized.Item6, timeNormalized.Item7);
        }
        public int getMillisecond()
        {
            return this.time.Millisecond;
        }
    }

}
