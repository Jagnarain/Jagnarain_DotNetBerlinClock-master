using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public class BerlinClock
    {
        private readonly ITimeConverter _topFirstTime;
        private readonly ITimeConverter _topSecondTime;
        private readonly ITimeConverter _bottomFirstTime;
        private readonly ITimeConverter _bottomSecondTime;
        private readonly ITimeConverter _lampGenerator;
        private readonly ValueBiggestFit _hourBiggestFit;
        private readonly ValueBiggestFit _minuteBiggestFit;

        public BerlinClock()
            : this(
                new TimeConverterTopFirst(),
                new TimeConverterTopSecond(),
                new TimeConverterBottomFirst(),
                new TimeConverterBottomSecond(),
                new TimeConverterYellowLamp())
        {
        }

        public BerlinClock(ITimeConverter topFirstTime, ITimeConverter topSecondTime,
            ITimeConverter bottomFirstTime, ITimeConverter bottomSecondTime, ITimeConverter lampGenerator)
        {
            _topFirstTime = topFirstTime;
            _topSecondTime = topSecondTime;
            _bottomFirstTime = bottomFirstTime;
            _bottomSecondTime = bottomSecondTime;
            _lampGenerator = lampGenerator;
            _hourBiggestFit = new ValueBiggestFit(new List<int> { 5, 10, 15, 20 });
            _minuteBiggestFit = new ValueBiggestFit(new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 35, 50, 55 });
        }

        public string Generate(DateTime timeOfDay)
        {
            return Generate(timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second);
        }

        public string Generate(int hour, int minute, int second)
        {
            int hoursFirstTime = hour;
            int hoursSecondTime = hour - _hourBiggestFit.GetFit(hour);

            int minutesFirstTime = minute;
            int minutesSecondTime = minute - _minuteBiggestFit.GetFit(minute);

            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}", _lampGenerator.Generate(second), _topFirstTime.Generate(hoursFirstTime), _topSecondTime.Generate(hoursSecondTime),
                _bottomFirstTime.Generate(minutesFirstTime), _bottomSecondTime.Generate(minutesSecondTime));
        }
    }

}
