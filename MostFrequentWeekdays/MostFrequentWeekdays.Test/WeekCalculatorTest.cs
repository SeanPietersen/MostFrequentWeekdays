using System;
using Xunit;

namespace MostFrequentWeekdays.Test
{
    public class WeekCalculatorTest
    {
        [Fact]
        public void MostFrequentDaysTest1()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Friday", "Saturday" };

            var year = 2016;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest2()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Monday"};

            var year = 1770;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest3()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Monday" };

            var year = 2001;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest4()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Monday", "Tuesday" };

            var year = 1968;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest5()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Saturday" };

            var year = 1785;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest6()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Saturday" };

            var year = 1910;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest7()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Saturday" };

            var year = 2135;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest8()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Sunday" };

            var year = 3043;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest9()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Sunday" };

            var year = 3150;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest10()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Thursday" };

            var year = 3361;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest11()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Tuesday" };

            var year = 1901;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest12()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Tuesday" };

            var year = 3230;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest13()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Wednesday" };

            var year = 1794;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MostFrequentDaysTest14()
        {
            //Arrange
            IWeekCalculator weekCalculator = new WeekCalculator();

            var expected = new[] { "Wednesday" };

            var year = 1986;

            //Act
            var actual = weekCalculator.MostFrequentDays(year);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
