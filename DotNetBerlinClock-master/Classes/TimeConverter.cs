using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public abstract class TimeConverter : ITimeConverter
    {
        protected char Smaller(int value, int valueToCompare, char trueReturnChar = 'R', char falseReturnChar = 'O')
        {
            if (value < valueToCompare) return falseReturnChar;
            return trueReturnChar;
        }

        public abstract string Generate(int minutes);
    }
}
