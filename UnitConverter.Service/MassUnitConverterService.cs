using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Models;

namespace UnitConverter.Service
{
    public class MassUnitConverterService : IUnitConverterService
    {
        public double Convert(int fromVal, int toVal, double value)
        {
            var from = (UnitTypeMass)fromVal;
            var to = (UnitTypeMass)toVal;
            
            var y = Units.massVal();
            double fromFactor = y[(int)from];
            double toFactor = y[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }
    }
}
