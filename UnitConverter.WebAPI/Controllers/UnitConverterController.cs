using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.Service;
namespace UnitConverter.WebAPI.Controllers
{
    [ApiController]
    [Route("Convert")]
    public class UnitConverterController : Controller
    {
        [HttpPost("length")]
        public ActionResult<double> Length_Convert(Model unitLengthRequest)
        {
            var convertService = new UnitConverterService();
            UnitTypeLength fromUnit, toUnit;
            if(Enum.TryParse(unitLengthRequest.FromUnit,out fromUnit)&& Enum.TryParse(unitLengthRequest.ToUnit,out toUnit))
            {
                double result= convertService.lengthConvert(fromUnit, toUnit, unitLengthRequest.SourceValue);
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
            var convertService = new UnitConverterService();
            UnitTypeMass fromUnit, toUnit;
            if (Enum.TryParse(unitMassRequest.FromUnit, out fromUnit) && Enum.TryParse(unitMassRequest.ToUnit, out toUnit))
            {
                double result = convertService.massConvert(fromUnit, toUnit,unitMassRequest.SourceValue);
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
            var convertService = new UnitConverterService();
            UnitTypeTime fromUnit, toUnit;
            if (Enum.TryParse(unitTimeRequest.FromUnit, out fromUnit) && Enum.TryParse(unitTimeRequest.ToUnit, out toUnit))
            {
                double result = convertService.timeConvert(fromUnit, toUnit, unitTimeRequest.SourceValue);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid Input");
            }
        }

    }
}
