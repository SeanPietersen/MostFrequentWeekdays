using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentWeekdays.App
{
    public interface IWeekCalculator
    {
        string[] MostFrequentDays(int year);
    }
}
