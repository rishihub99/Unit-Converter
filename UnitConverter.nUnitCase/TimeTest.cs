using Newtonsoft.Json.Linq;
using UnitConverter.Service;
using UnitConverter.Models;
using NUnit.Framework;


namespace UnitConverter.nUnitCase
{
    public class TimeTest
    {
        private TimeUnitConverterService _timeUnitConverterService { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _timeUnitConverterService = new TimeUnitConverterService();
        }

        [Test]

        public void MassUnitConverterService_EqualTest()
        {
            var fromVal = 1;
            var toVal = 0;
            var value = 1;

            var result = _timeUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreEqual(0.001, result);
        }


        [Test]
        public void TimeUnitConverterService_NotEqualTest()
        {
            var fromVal = 1;
            var toVal = 0;
            var value = 1;

            var result = _timeUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreNotEqual(0.01, result);
        }
    }
}