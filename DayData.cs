using System;

namespace MoodTracker
{
    public class DayData
    {
        public Date Date;
        public string Mood;
        public string Note;

        public override bool Equals(object obj)
        {
            if (obj is DayData objData)
            {
                return Date.Equals(objData.Date);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Date.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"{Date.ToString()} {Mood} {Note}";
        }
    }
}
