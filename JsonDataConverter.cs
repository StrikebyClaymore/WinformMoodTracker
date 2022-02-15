using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoodTracker
{
    public class JsonDataConverter
    {
        private readonly JsonSerializerOptions _options;
        public JsonData JsonAllData;

        public JsonDataConverter()
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }
        
        public string DataConvertToJson()
        {
            List<DayData> data = Program.Database.Data;
            JsonData jsonData = JsonAllData;

            if (data.Count == 0)
                return null;

            if (jsonData is null)
                jsonData = new JsonData{Years = new List<JsonYear>()};

            Date selectedDate = Program.Database.SelectedDate;

            JsonMonth month = new JsonMonth
            {
                Month = selectedDate.Month,
                Days = new List<JsonDay>()
            };

            foreach (DayData day in data)
            {
                var jsonDay = new JsonDay
                {
                    Day = day.Date.Day,
                    Mood = day.Mood,
                    Note = day.Note
                };
                month.Days.Add(jsonDay);
            }
            
            JsonYear year = jsonData.Years.FirstOrDefault(jsonYear => jsonYear.Year == selectedDate.Year);

            if (year is null)
            {
                year = new JsonYear();
                year.Year = Program.Database.SelectedDate.Year;
                year.Months = new List<JsonMonth> { month };
                jsonData.Years.Add(year);

            }
            else
            {
                for (int i = 0; i < year.Months.Count; i++)
                {
                    if (year.Months[i].Month == month.Month)
                    {
                        year.Months[i] = month;
                        break;
                    }
                    if (i == year.Months.Count - 1)
                        year.Months.Add(month);
                }
            }

            return JsonSerializer.Serialize(jsonData, _options);
        }

        public List<DayData> JsonConvertToData(string jsonStringData, Date selectedDate)
        {
            JsonAllData = JsonSerializer.Deserialize<JsonData>(jsonStringData);
            return ReadMonth(selectedDate);
        }
        
        public List<DayData> ReadMonth(Date selectedDate)
        {
            JsonYear year = JsonAllData.Years.FirstOrDefault(jsonYear => jsonYear.Year == selectedDate.Year);

            if (year is null)
                return new List<DayData>();

            JsonMonth month = year.Months.FirstOrDefault(jsonMonth => jsonMonth.Month == selectedDate.Month);

            if (month is null)
                return new List<DayData>();

            List<JsonDay> days = month.Days;

            List<DayData> data = new List<DayData>();

            foreach (JsonDay day in days)
            {
                Date date = new Date(year.Year, month.Month, day.Day);
                DayData dayData = new DayData
                {
                    Date = date,
                    Mood = day.Mood,
                    Note = day.Note
                };
                data.Add(dayData);
            }

            return data;
        }

        public Date GetNextDate(int next)
        {
            Date date = new Date(Program.Database.SelectedDate);

            JsonYear year = JsonAllData.Years.FirstOrDefault(jsonYear => jsonYear.Year == date.Year);

            if (year.Months.FirstOrDefault(jsonMonth => jsonMonth.Month == date.Month + next) is null)
            {
                if (next == 1)
                {
                    year = JsonAllData.Years.FirstOrDefault(jsonYear => jsonYear.Year > date.Year);
                    date.Month = 0;
                }
                else
                {
                    year = JsonAllData.Years.FirstOrDefault(jsonYear => jsonYear.Year < date.Year);
                    date.Month = 13;
                }
            }

            if (year is null)
                return null;

            JsonMonth month = null;
            if (next == 1)
                month = year.Months.FirstOrDefault(jsonMonth => jsonMonth.Month > date.Month);
            else if (next == -1)
                month = year.Months.LastOrDefault(jsonMonth => jsonMonth.Month < date.Month);

            if (month is null)
                return null;

            JsonDay day = month.Days.FirstOrDefault();
            date = new Date(year.Year, month.Month, day.Day);
            DayData dayData = new DayData
            {
                Date = date,
                Mood = day.Mood,
                Note = day.Note
            };

            return date;
        }
    }
    
    public class JsonData
    {
        public List<JsonYear> Years { get; set; }
    }

    public class JsonYear
    {
        public int Year { get; set; }
        public List<JsonMonth> Months { get; set; }
    }

    public class JsonMonth
    {
        public int Month { get; set; }
        public List<JsonDay> Days { get; set; }
    }

    public class JsonDay
    {
        public int Day { get; set; }
        public string Mood { get; set; }
        public string Note { get; set; }
    }
}
