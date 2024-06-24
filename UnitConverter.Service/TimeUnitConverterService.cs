using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Models;

namespace UnitConverter.Service
{
    public class TimeUnitConverterService: IUnitConverterService
    {
        public double Convert(int fromVal, int toVal, double value)
        {
            var from = (UnitTypeTime)fromVal;
            var to = (UnitTypeTime)toVal;
            var z = Units.timeVal();
            double fromFactor = z[(int)from];
            double toFactor = z[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }
    }
}
