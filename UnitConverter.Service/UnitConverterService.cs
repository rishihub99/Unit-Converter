using UnitConverter.Models;
//using UnitConverter.WebAPI;

namespace UnitConverter.Service
{
    public class UnitConverterService
    {


        //private static readonly Units _units;

        //public UnitConverterService()
        //{
        //    _units = units;
        //}


        public double lengthConvert(UnitTypeLength from, UnitTypeLength to, double value)
        {
            //Console.WriteLine(UnitTypeLength from, UnitTypeLength to);

            var x=Units.lenVal();
            double fromFactor =x[(int)from];
            double toFactor = x[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }

        public double massConvert(UnitTypeMass from, UnitTypeMass to, double value)
        {
            var y = Units.massVal();
            double fromFactor = y[(int)from];
            double toFactor = y[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }

        public double timeConvert(UnitTypeTime from, UnitTypeTime to, double value)
        {
            var z = Units.timeVal();
            double fromFactor = z[(int)from];
            double toFactor = z[(int)to];
            return value * (fromFactor / toFactor);

            throw new ArgumentException("Invalid unit type.");
        }
        //private readonly Dictionary<UnitTypeLength, double>? _LengthConversionFactor;
        //private readonly Dictionary<UnitTypeMass, double>? _MassConversionFactor;
        //private readonly Dictionary<UnitTypeTime, double>? _TimeConversionFactor;

        //public UnitConverterService()
        //{
        //    _LengthConversionFactor = new Dictionary<UnitTypeLength, double>();
        //    _MassConversionFactor = new Dictionary<UnitTypeMass, double>();
        //    _TimeConversionFactor = new Dictionary<UnitTypeTime, double>();

        //    InitializeConversionTable();

        //}
        //public void InitializeConversionTable()
        //{
        //    _LengthConversionFactor[UnitTypeLength.feet] = 0.3048;
        //    _LengthConversionFactor[UnitTypeLength.inch] = 0.0254;
        //    _LengthConversionFactor[UnitTypeLength.meter] = 1.0000;
        //    _LengthConversionFactor[UnitTypeLength.kilometer] = 1000;

        //    _MassConversionFactor[UnitTypeMass.pound] = 0.453592;
        //    _MassConversionFactor[UnitTypeMass.ounce] = 0.0283495;
        //    _MassConversionFactor[UnitTypeMass.gram] = 0.001;
        //    _MassConversionFactor[UnitTypeMass.kilogram] = 1.0000;

        //    _TimeConversionFactor[UnitTypeTime.milisecond] = 0.001;
        //    _TimeConversionFactor[UnitTypeTime.second] = 1.0000;

        //}
        //public double lengthConvert(UnitTypeLength from, UnitTypeLength to, double value)
        //{
        //    string _from = from.ToString();
        //    string _to = to.ToString();
        //    Console.WriteLine(_from, _to, value);
        //    if (_LengthConversionFactor.ContainsKey(from) && _LengthConversionFactor.ContainsKey(to))
        //    {
        //        double fromFactor = _LengthConversionFactor[from];
        //        double toFactor = _LengthConversionFactor[to];
        //        return value * (fromFactor / toFactor);
        //    }
        //    throw new ArgumentException("Invalid unit type.");
        //}

        //public double massConvert(UnitTypeMass from, UnitTypeMass to, double value)
        //{
        //    if (_MassConversionFactor.ContainsKey(from) && _MassConversionFactor.ContainsKey(to))
        //    {
        //        double fromFactor = _MassConversionFactor[from];
        //        double toFactor = _MassConversionFactor[to];
        //        return value * (fromFactor / toFactor);
        //    }
        //    throw new ArgumentException("Invalid unit type.");
        //}

        //public double timeConvert(UnitTypeTime from, UnitTypeTime to, double value)
        //{
        //    if (_TimeConversionFactor.ContainsKey(from) && _TimeConversionFactor.ContainsKey(to))
        //    {
        //        double fromFactor = _TimeConversionFactor[from];
        //        double toFactor = _TimeConversionFactor[to];
        //        return value * (fromFactor / toFactor);
        //    }
        //    throw new ArgumentException("Invalid unit type.");
        //}




    }
}
