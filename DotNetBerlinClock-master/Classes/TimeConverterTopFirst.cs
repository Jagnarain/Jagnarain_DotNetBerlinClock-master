using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeConverterTopFirst : TimeConverter
    {
        public override string Generate(int minutes)
        {
            return String.Format("{3}{2}{1}{0}",
                Smaller(minutes, 20),
                Smaller(minutes, 15),
                Smaller(minutes, 10),
                Smaller(minutes, 5));
        }
    }
}
