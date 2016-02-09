using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class TimeConverterTopSecond : TimeConverter
    {
        public override string Generate(int minutes)
        {
            return String.Format("{3}{2}{1}{0}", Smaller(minutes, 4), Smaller(minutes, 3), Smaller(minutes, 2), Smaller(minutes, 1));
        }
    }
}
