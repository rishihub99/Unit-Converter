using Newtonsoft.Json.Linq;
using UnitConverter.Service;
using UnitConverter.Models;
using NUnit.Framework;


namespace UnitConverter.nUnitCase
{
    public class LengthTest
    {
        private LengthUnitConverterService _lengthUnitConverterService { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _lengthUnitConverterService=new LengthUnitConverterService();
        }

        [Test]
        
        public void LengthUnitConverterService_EqualTest()
        {
            var fromVal = 2;
            var toVal = 3;
            var value = 1000;

            var result = _lengthUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreEqual(1,result);
        }

        [Test]
        public void LengthUnitConverterService_NotEqualTest()
        {
            var fromVal = 2;
            var toVal = 3;
            var value = 1000;

            var result = _lengthUnitConverterService.Convert(fromVal, toVal, value);


            Assert.AreNotEqual(10,result);
        }
    }
}