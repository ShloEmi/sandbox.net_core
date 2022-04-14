using FluentAssertions;
using NUnit.Framework;
using System;

namespace BasicsTests
{
    public class TimeSpanTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test, AutoNSubstituteData]
        public void TotalHours__When_HoursRoundUp__ExpectedRoundUpHour(int hours)
        {
            var format = "00";
            var hoursRoundUp = new TimeSpan(days: 0, hours: hours, minutes: 55, seconds: 56);


            //act
            hoursRoundUp.TotalHours.ToString(format).Should().BeEquivalentTo((hours+1).ToString(format));
        }

        [Test, AutoNSubstituteData]
        public void TotalHours__Using_Math_Floor__ExpectedNoRoundUpHour(int hours)
        {
            var format = "N0";
            var hoursRoundUp = new TimeSpan(days: 0, hours: hours, minutes: 55, seconds: 56);


            //act
            Math.Floor(hoursRoundUp.TotalHours).ToString(format).Should().BeEquivalentTo(hours.ToString("00"));
        }
    }
}