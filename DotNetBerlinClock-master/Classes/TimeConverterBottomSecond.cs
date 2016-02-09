using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeConverterBottomSecond : TimeConverter
    {
        public override string Generate(int minutes)
        {
            return String.Format("{3}{2}{1}{0}",
                Smaller(minutes, 4, 'Y'),
                Smaller(minutes, 3, 'Y'),
                Smaller(minutes, 2, 'Y'),
                Smaller(minutes, 1, 'Y'));
        }
    }
}
