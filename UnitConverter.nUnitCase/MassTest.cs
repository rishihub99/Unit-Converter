using Newtonsoft.Json.Linq;
using UnitConverter.Service;
using UnitConverter.Models;
using NUnit.Framework;


namespace UnitConverter.nUnitCase
{
    public class MassTest
    {
        private MassUnitConverterService _massUnitConverterService { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _massUnitConverterService = new MassUnitConverterService();
        }

        [Test]

        public void MassUnitConverterService_EqualTest()
        {
            var fromVal = 2;
            var toVal = 3;
            var value = 1000;

            var result = _massUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreEqual(1, result);
        }


        [Test]
        public void MassUnitConverterService_NotEqualTest()
        {
            var fromVal = 2;
            var toVal = 3;
            var value = 1000;

            var result = _massUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreNotEqual(10, result);
        }
    }
}