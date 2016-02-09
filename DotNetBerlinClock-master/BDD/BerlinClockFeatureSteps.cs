using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BerlinClock.Classes;

namespace BerlinClock
{
    [TestClass]
    public class TheBerlinClockSteps
    {
        /*
            Scenario: Midnight 00:00
            When the time is "00:00:00"
            Then the clock should look like
            """
            Y
            OOOO
            OOOO
            OOOOOOOOOOO
            OOOO
            """
         */
        [TestMethod]
        public void WhenTheTimeIs_Midnight()
        {
            int hours = 00;
            int minutes = 00;
            int seconds = 00;
            string expectedResult = "Y\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO";

            var topFirstTime = new TimeConverterTopFirst();
            var topSecondTime = new TimeConverterTopSecond();
            var bottomFirstTime = new TimeConverterBottomFirst();
            var bottomSecondTime = new TimeConverterBottomSecond();
            var yellowLampGen = new TimeConverterYellowLamp();

            var clock = new BerlinClock.Classes.BerlinClock(topFirstTime,
                topSecondTime, bottomFirstTime, bottomSecondTime, yellowLampGen);

            var result = clock.Generate(hours, minutes, seconds);
            Assert.AreEqual(result, expectedResult);
        }

        /*
            Scenario: Middle of the afternoon
            When the time is "13:17:01"
            Then the clock should look like
            """
            O
            RROO
            RRRO
            YYROOOOOOOO
            YYOO
            """
         */
        [TestMethod]
        public void WhenTheTimeIs_MiddleOfTheAfternoon()
        {
            int hours = 13;
            int minutes = 17;
            int seconds = 01;
            string expectedResult = "O\nRROO\nRRRO\nYYROOOOOOOO\nYYOO";

            var topFirstTime = new TimeConverterTopFirst();
            var topSecondTime = new TimeConverterTopSecond();
            var bottomFirstTime = new TimeConverterBottomFirst();
            var bottomSecondTime = new TimeConverterBottomSecond();
            var yellowLampGen = new TimeConverterYellowLamp();

            var clock = new BerlinClock.Classes.BerlinClock(topFirstTime,
                topSecondTime, bottomFirstTime, bottomSecondTime, yellowLampGen);

            var result = clock.Generate(hours, minutes, seconds);
            Assert.AreEqual(result, expectedResult);
        }

        /*
            Scenario: Just before midnight
            When the time is "23:59:59"
            Then the clock should look like
            """
            O
            RRRR
            RRRO
            YYRYYRYYRYY
            YYYY
            """
         */
        [TestMethod]
        public void WhenTheTimeIs_JustBeforeMidnight()
        {
            int hours = 23;
            int minutes = 59;
            int seconds = 59;
            string expectedResult = "O\nRRRR\nRRRO\nYYRYYRYYRYY\nYYYY";

            var topFirstTime = new TimeConverterTopFirst();
            var topSecondTime = new TimeConverterTopSecond();
            var bottomFirstTime = new TimeConverterBottomFirst();
            var bottomSecondTime = new TimeConverterBottomSecond();
            var yellowLampGen = new TimeConverterYellowLamp();

            var clock = new BerlinClock.Classes.BerlinClock(topFirstTime,
                topSecondTime, bottomFirstTime, bottomSecondTime, yellowLampGen);

            var result = clock.Generate(hours, minutes, seconds);
            Assert.AreEqual(result, expectedResult);
        }

        /*
            Scenario: Midnight 24:00
            When the time is "24:00:00"
            Then the clock should look like
            """
            Y
            RRRR
            RRRR
            OOOOOOOOOOO
            OOOO
            """
         */
        [TestMethod]
        public void WhenTheTimeIs_Midnight_1()
        {
            int hours = 24;
            int minutes = 00;
            int seconds = 00;
            string expectedResult = "Y\nRRRR\nRRRR\nOOOOOOOOOOO\nOOOO";

            var topFirstTime = new TimeConverterTopFirst();
            var topSecondTime = new TimeConverterTopSecond();
            var bottomFirstTime = new TimeConverterBottomFirst();
            var bottomSecondTime = new TimeConverterBottomSecond();
            var yellowLampGen = new TimeConverterYellowLamp();

            var clock = new BerlinClock.Classes.BerlinClock(topFirstTime,
                topSecondTime, bottomFirstTime, bottomSecondTime, yellowLampGen);

            var result = clock.Generate(hours, minutes, seconds);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
