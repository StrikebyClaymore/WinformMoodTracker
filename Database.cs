using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MoodTracker
{
    public class Database
    {
        private DatabaseReader _databaseReader = new DatabaseReader();
        public List<DayData> Data;
        public Date SelectedDate;

        public Database()
        {
            SelectedDate = Program.Date;
            Data = _databaseReader.ReadJson(Program.Date);

            SortData();
        }

        public void AddData()
        {
            if (Data.Contains(Program.CurrentData))
                return;

            Data.Add(Program.CurrentData);
        }

        public DayData CreateData(Date date)
        {
            DayData lastData = GetData(Data.Count - 1);
            DayData newData;
            if (!(lastData is null) && lastData.Date.Equals(date))
                newData = lastData;
            else
            {
                newData = new DayData();
                newData.Date = date;
            }
            return newData;
        }

        public DayData GetData(int idx)
        {
            if (Data.Count == 0 || Data.Count - 1 < idx)
                return null;
            return Data[idx];
        }

        public DayData GetData(string day) => Data.First(data => data.Date.Day.ToString() == day);

        public void SetMonthData(Date date)
        {
            
        }
        
        public bool SelectDate(int next)
        {
            Date nextDate = _databaseReader.ReadNextDate(next);

            if (nextDate is null)
                return false;

            SelectedDate = nextDate;
            Data = _databaseReader.ReadJson(SelectedDate);
            return true;
        }
        
        public void SaveData()
        {
            _databaseReader.WriteJson();
        }

        private void SortData()
        {
            Data.Sort(delegate (DayData d1, DayData d2)
            {
                if (d1.Date == null && d2.Date == null) return 0;
                else if (d1.Date == null) return -1;
                else if (d2.Date == null) return 1;
                else return d1.Date.Day.CompareTo(d2.Date.Day);
            });
        }
    }
}
