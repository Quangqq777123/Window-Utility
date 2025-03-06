using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowUtility
{
    internal class CustomTime
    {
        private int hour;
        private int minute;
        private int second;
        private int milliSecond;

        public CustomTime(int hour, int minute, int second, int milliSecond)
        {
            this.hour = Math.Abs(hour);
            this.minute = Math.Abs(minute);
            this.second = Math.Abs(second);
            this.milliSecond = Math.Abs(milliSecond);
        }

        public CustomTime(int hour, int minute, int second)
        {
            this.hour = Math.Abs(hour);
            this.minute = Math.Abs(minute);
            this.second = Math.Abs(second);
            this.milliSecond = 0;
        }

        public int Hour
        {
            get { return this.hour; }
            set { this.hour = Math.Abs(value); }
        }

        public int Minute
        {
            set { this.minute = Math.Abs(value); }
            get { return this.minute; }
        }

        public int Second
        {
            set { this.second = Math.Abs(value); }
            get { return this.second; }
        }
        
        public int MilliSecond
        {
            set { this.milliSecond = Math.Abs(value); }
            get { return this.milliSecond; }           
        }

        public void timeNormalization()
        {
            int temp = this.milliSecond / 1000;
            this.milliSecond %= 1000;
            temp = (temp + this.second) / 60;
            this.second = (temp + this.second) % 60;
            temp = (temp + this.minute) / 60;
            this.minute = (temp + this.minute) % 60;
            temp = (temp + this.hour) / 24;
            this.hour = (temp + this.hour) % 24;
        }

        public int calculateSecond()
        {
            this.timeNormalization();
            return this.hour*3600 + this.minute*60 + this.second + this.milliSecond/1000;
        }


    }
}
