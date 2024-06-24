using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.Service;
namespace UnitConverter.WebAPI.Controllers
{
    [ApiController]
    [Route("Convert")]
    public class UnitConverterController : Controller
    {
        IUnitConverterService _iUnitConvertLength;
        IUnitConverterService _iUnitConvertMass;
        IUnitConverterService _iUnitConvertTime;
        public UnitConverterController(IUnitConverterService iUnitConvert)
        {
            _iUnitConvertLength = new LengthUnitConverterService();
            _iUnitConvertMass = new MassUnitConverterService();
            _iUnitConvertTime=new TimeUnitConverterService();
        }
        [HttpPost("length")]
        public ActionResult<double> Length_Convert(Model unitLengthRequest)
        {
            //var convertService = new UnitConverterService();
            UnitTypeLength fromUnit, toUnit;
            if (Enum.TryParse(unitLengthRequest.FromUnit, out fromUnit) && Enum.TryParse(unitLengthRequest.ToUnit, out toUnit))
            {
                double result = _iUnitConvertLength.Convert((int)fromUnit, (int)toUnit, unitLengthRequest.SourceValue);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid Input");
            }
        }
        [HttpPost("mass")]
        public ActionResult<double> Mass_Convert(Model unitMassRequest)
        {
            //var convertService = new UnitConverterService();
            UnitTypeMass fromUnit, toUnit;
            if (Enum.TryParse(unitMassRequest.FromUnit, out fromUnit) && Enum.TryParse(unitMassRequest.ToUnit, out toUnit))
            {
                double result = _iUnitConvertMass.Convert((int)fromUnit, (int)toUnit, unitMassRequest.SourceValue);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid Input");
            }
        }
        [HttpPost("time")]
        public ActionResult<double> Time_Convert(Model unitTimeRequest)
        {
            UnitTypeTime fromUnit, toUnit;
            if (Enum.TryParse(unitTimeRequest.FromUnit, out fromUnit) && Enum.TryParse(unitTimeRequest.ToUnit, out toUnit))
            {
                double result = _iUnitConvertTime.Convert((int)fromUnit, (int)toUnit, unitTimeRequest.SourceValue);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid Input");
            }
        }

    }
}
