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
        public void TotalHours_When_HoursRoundUp_ExpectedRoundUpHour(int hours)
        {
            var format = "00";
            var hoursRoundUp = new TimeSpan(days: 0, hours: hours, minutes: 55, seconds: 56);


            //act
            hoursRoundUp.TotalHours.ToString(format).Should().BeEquivalentTo((hours+1).ToString(format));
        }
    }
}