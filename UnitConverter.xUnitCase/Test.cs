using UnitConverter.Service;
using UnitConverter.Models;
using Xunit;
using System;

namespace UnitConverter.xUnitCase
{
    public class LengthTest
    {
        private LengthUnitConverterService _lengthUnitConverterService { get; set; } = null;

        public LengthTest()
        {
            _lengthUnitConverterService = new LengthUnitConverterService();
            
        }
        
        [Fact]
        public void LengthUnitConverterService_EqualTest()
        {
            
            var fromValue = 2;
            var toValue = 3;
            var value = 1000;
            var result=_lengthUnitConverterService.Convert(fromValue, toValue, value);

            Assert.Equal(1, result);

        }

        [Fact]
        public void LengthUnitConverterService_NotEqualTest()
        {

            var fromValue = 2;
            var toValue = 3;
            var value = 1000;
            var result = _lengthUnitConverterService.Convert(fromValue, toValue, value);

            Assert.NotEqual(10, result);

        }
    }



    public class MassTest 
    {
        private MassUnitConverterService _massUnitConverterService { get; set; } = null;

        public MassTest()
        {
            _massUnitConverterService = new MassUnitConverterService();

        }
        [Fact]
        public void MassUnitConverterService_EqualTest()
        {

            var fromValue = 2;
            var toValue = 3;
            var value = 1000;
            var result = _massUnitConverterService.Convert(fromValue, toValue, value);

            Assert.Equal(1, result);

        }

        [Fact]
        public void MassUnitConverterService_NotEqualTest()
        {

            var fromValue = 2;
            var toValue = 3;
            var value = 1000;
            var result = _massUnitConverterService.Convert(fromValue, toValue, value);

            Assert.NotEqual(10, result);

        }
    }


    public class TimeTest 
    {
        private TimeUnitConverterService _timeUnitConverterService { get; set; } = null;

        public TimeTest()
        {
            _timeUnitConverterService = new TimeUnitConverterService();

        }
        
        [Fact]
        public void TimeUnitConverterService_EqualTest()
        {

            var fromValue = 1;
            var toValue = 0;
            var value = 1;
            var result = _timeUnitConverterService.Convert(fromValue, toValue, value);

            Assert.Equal(0.001, result);

        }

        [Fact]
        public void TimeUnitConverterService_NotEqualTest()
        {

            var fromValue = 1;
            var toValue = 0;
            var value = 1;
            var result = _timeUnitConverterService.Convert(fromValue, toValue, value);

            Assert.NotEqual(0.01, result);

        }
    }
}