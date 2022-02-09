using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace MoodTracker
{
    public class DatabaseReader
    {
        private readonly JsonDataConverter _jsonDataConverter = new JsonDataConverter();
        
        private const string JsonDataPath = @"C:\Users\CGO\Documents\Code\C#\MoodTracker\resources\data\jsonData.json";

        public void WriteJson()
        {
            string jsonStringData = _jsonDataConverter.DataConvertToJson();

            //Debug.WriteLine(jsonStringData);

            File.WriteAllText(JsonDataPath, jsonStringData);
        }
        
        public List<DayData> ReadJson(Date date)
        {
            if (!File.Exists(JsonDataPath))
                return new List<DayData>();

            string jsonStringData = File.ReadAllText(JsonDataPath);
            
            //Debug.WriteLine(jsonStringData);
            
            if (jsonStringData is null || jsonStringData == "")
                return new List<DayData>();

            List<DayData> data = _jsonDataConverter.JsonConvertToData(jsonStringData, date);
            return data;
        }

        public Date ReadNextDate(int next)
        {
            return _jsonDataConverter.GetNextDate(next);
        }

        public DayData ConvertToDayData(string entry)
        {
            string[] split = entry.Split("[/s]");
            string note = "";
            for (int i = 0; i < split.Length; i++)
            {
                if (i == 0 || i == 1)
                    continue;
                note += split[i];
            }
            DayData data = new DayData()
            {
                Date = new Date(split[0]),
                Mood = split[1],
                Note = note
            };
            return data;
        }
    }
}
