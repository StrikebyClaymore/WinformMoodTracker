using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MoodTracker
{
    public class Date
    {
        public int Year;
        public int Month;
        public int Day;

        public Date(string date)
        {
            string[] split = date.Split('.');
            Year = int.Parse(split[2]);
            Month = int.Parse(split[1]);
            Day = int.Parse(split[0]);
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        
        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Date date)
            {
                return Year == date.Year && Month == date.Month && Day == date.Day;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }

        public int CompareTo(Date date)
        {
            if (date == null)
                return 1;
            else
                return ToString().CompareTo(date.ToString());
        }
    }
}
