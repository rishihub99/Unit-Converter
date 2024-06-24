using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Models
{
    public enum UnitType
    {
        Length,
        Mass,
        Time
    }
    public enum UnitTypeLength
    {
        feet,
        inch ,
        meter,
        kilometer
    }
    public enum UnitTypeMass
    {
        pound,
        ounce,
        gram,
        kilogram
    }
    public enum UnitTypeTime
    {
        second,
        milisecond
    }

}
