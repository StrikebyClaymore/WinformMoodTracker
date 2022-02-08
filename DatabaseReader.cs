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
        
        private const string DataPath = @"C:\Users\CGO\Documents\Code\C#\MoodTracker\resources\data\data.txt";
        private const string JsonDataPath = @"C:\Users\CGO\Documents\Code\C#\MoodTracker\resources\data\jsonData.json";

        public List<DayData> Read()
        {
            if (!File.Exists(DataPath))
                return new List<DayData>();
            string[] stringData = File.ReadAllLines(DataPath);
            List<DayData> data = new List<DayData>();
            foreach (string line in stringData)
                data.Add(ConvertToDayData(line));
            return data;
        }

        public DayData ReadLast()
        {
            if (!File.Exists(DataPath))
                return null;
            string entry = !(File.ReadLines(DataPath) is string[] data) ? "" : data.Last();
            if (entry == "")
                return null;
            string[] split = entry.Split("[/s]");
            entry = split[0] + split[1] + entry.Split(split[0] + split[1]);
            return ConvertToDayData(entry);
        }

        public void Write(DayData data)
        {
            string line = data.Date + "[/s]" + data.Mood + "[/s]" + data.Note;

            using StreamWriter file = new StreamWriter(DataPath, true);
            file.WriteLine(line);
            //foreach (string line in data){}
        }

        public void WriteAll(List<DayData> data)
        {

            File.WriteAllText(DataPath, String.Empty);
            using StreamWriter file = new StreamWriter(DataPath, true);
            foreach (DayData d in data)
            {
                Debug.WriteLine(d.Date + " " + d.Mood + " " + d.Note);
                string line = d.Date + "[/s]" + d.Mood + "[/s]" + d.Note;
                file.WriteLine(line);
            }
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

        public void WriteJson()
        {
            string jsonStringData = _jsonDataConverter.DataConvertToJson();
            File.WriteAllText(JsonDataPath, jsonStringData);
        }
        
        public List<DayData> ReadJson(Date date)
        {
            if (!File.Exists(DataPath))
                return new List<DayData>();
            string jsonStringData = File.ReadAllText(JsonDataPath);
            
            Debug.WriteLine(jsonStringData);
            
            if (jsonStringData is null || jsonStringData == "")
                return new List<DayData>();
            
            List<DayData> data = _jsonDataConverter.JsonConvertToData(jsonStringData, date);
            return data;
        }
        
    }
}
