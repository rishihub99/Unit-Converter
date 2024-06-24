using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Models;

namespace UnitConverter.Service
{
    public class LengthUnitConverterService : IUnitConverterService
    {
        public double Convert(int fromVal, int toVal, double value)
        {
            //Console.WriteLine(UnitTypeLength from, UnitTypeLength to);
            var from = (UnitTypeLength)fromVal;
            var to = (UnitTypeLength)toVal;

            var x = Units.lenVal();
            double fromFactor = x[(int)from];
            double toFactor = x[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }
    }
}
