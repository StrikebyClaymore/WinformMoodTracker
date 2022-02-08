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

        public Database()
        {
            Data = _databaseReader.Read();
            //Program.Database.Data = ReadJson(Program.Date);
            var data = _databaseReader.ReadJson(Program.Date);
            Debug.WriteLine("READ IN JSON");
            foreach (var d in data)
            {
                Debug.WriteLine(d.ToString());
            }
        }

        public void AddData()
        {
            if (Data.Contains(Program.CurrentData))
                return;

            Data.Add(Program.CurrentData);
            _databaseReader.Write(Program.CurrentData);
        }

        public DayData CreateData(Date date)
        {
            Debug.WriteLine(date.ToString());
            DayData lastData = GetData(Data.Count - 1);
            DayData newData;
            if (lastData.Date.Equals(date))
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
            if (Data.Count - 1 < idx)
                return null;
            return Data[idx];
        }

        public DayData GetData(string day) => Data.First(data => data.Date.Day.ToString() == day);

        public void SetMonthData(Date date)
        {
            
        }
        
        public bool SelectDate(Date date)
        {
            //if ()
            return false;
        }
        
        public void SaveData()
        {
            _databaseReader.WriteAll(Data);
            _databaseReader.WriteJson();
        }
        
    }
}
