using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeConverterYellowLamp : ITimeConverter
    {
        public string Generate(int minutes)
        {
            if (minutes % 2 == 0) return "Y";
            return "O";
        }
    }
}
