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

            Date selectedDate = Program.Database.Data.First().Date; 

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
                year.Year = data.First().Date.Year;
                year.Months = new List<JsonMonth> {month};
                jsonData.Years.Add(year);
            }
            else
                for (int i = 0; i < year.Months.Count; i++)
                    if (year.Months[i].Month == month.Month)
                    {
                        year.Months[i] = month;
                        break;
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

            /*if (year is null)
                return null;*/
            
            Debug.WriteLine(year);
            
            JsonMonth month = year.Months.FirstOrDefault(jsonMonth => jsonMonth.Month == selectedDate.Month);
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

/*private void WriteJson()
 {
     
     
     var options = new JsonSerializerOptions
     {
         WriteIndented = true,
     };
     
     var weatherForecast = new WeatherForecast();
     
     /*var jsonData = new JsonData();
     jsonData.years.Add(new JsonYear{name = "2022"});
     jsonData.years[0].months.Add(new JsonMonth{name = "2"});
     jsonData.years[0].months[0].days.Add(new JsonDay{Year = 1, Month = 1, Day = 1});#1#

     
     var month = new JsonMonth()
     {
         month = 0,
         days = new List<JsonDay>
             {new JsonDay {Day = 1}, new JsonDay {Day = 2}}
     };
     
     var year = new JsonYear()
     {
         year = 0,
         months = new List<JsonMonth>{ month }
     };

     var year1 = new JsonYear()
     {
         year = 1,
         months = new List<JsonMonth>{ month }
     };
     
     var data = new JsonData()
     {
         years = new List<JsonYear>
         {
             year, year1
         }
     };
     
     string jsonString = JsonSerializer.Serialize(data, options);

     File.WriteAllText(path, jsonString);

     Debug.WriteLine("WRITED");

     jsonString = File.ReadAllText(path);
     var jsonDataRead = JsonSerializer.Deserialize<JsonData>(jsonString);
     Debug.WriteLine(jsonDataRead.years.First(year => year.year == 1));//[0].months[0].days[0].Day

 }*/