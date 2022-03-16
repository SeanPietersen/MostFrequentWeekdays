using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentWeekdays.App
{
    public class WeekCalculator : IWeekCalculator
    {
        public string[] MostFrequentDays(int year)
        {
            var start = new DateTime(year, 1, 1);
            var end = start.AddYears(1);
            
            var daysOfWeek = new Dictionary<DayOfWeek, int>()
            {
                { DayOfWeek.Monday, 0},
                { DayOfWeek.Tuesday, 0},
                { DayOfWeek.Wednesday, 0},
                { DayOfWeek.Thursday, 0},
                { DayOfWeek.Friday, 0},
                { DayOfWeek.Saturday, 0},
                { DayOfWeek.Sunday, 0},
            };

            while (start < end)
            {                
                switch (start.DayOfWeek)
                {
                    case  DayOfWeek.Monday:
                        daysOfWeek[DayOfWeek.Monday] += 1;
                        break;

                    case DayOfWeek.Tuesday:
                        daysOfWeek[DayOfWeek.Tuesday] += 1;
                        break;

                    case DayOfWeek.Wednesday:
                        daysOfWeek[DayOfWeek.Wednesday] += 1;
                        break;

                    case DayOfWeek.Thursday:
                        daysOfWeek[DayOfWeek.Thursday] += 1;
                        break;

                    case DayOfWeek.Friday:
                        daysOfWeek[DayOfWeek.Friday] += 1;
                        break;

                    case DayOfWeek.Saturday:
                        daysOfWeek[DayOfWeek.Saturday] += 1;
                        break;

                    case DayOfWeek.Sunday:
                        daysOfWeek[DayOfWeek.Sunday] += 1;
                        break;
                }
                start = start.AddDays(1);
            }

            List<string> list = new List<string>();

            var maxValue = daysOfWeek.Values.Max();

            foreach (var day in daysOfWeek)
            {
                if(day.Value >= maxValue)
                {
                    list.Add(day.Key.ToString());
                }    
            }

            string[] arrayOfDays = list.ToArray();
            return arrayOfDays;
            
            //var maxValue = daysOfWeek.Where(x => x.Value == daysOfWeek.Values.Max()).Select(x => x.Key).OrderByDescending(x => x).ToString();
            //throw new NotImplementedException();
        }
    }
}
