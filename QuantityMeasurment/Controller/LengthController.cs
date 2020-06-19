using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;
using Serilog;

namespace QuantityMeasurment.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        public IQuantityManager _Manager;
        public LengthController(IQuantityManager manager)
        {
            this._Manager = manager;
        }

        [HttpPost]
        [Route("CalculateLength")]
        public IActionResult CalculateLength(Length length)
        {
            var item = _Manager.CalculateLength(length);
            try
            {
                if (length.convertUnits == convertUnit.FeetToInch.ToString())
                {
                    return this.Ok(item);
                }
                else if (length.convertUnits == convertUnit.InchToFeet.ToString())
                {
                    return this.Ok(item);
                }
                else if (length.convertUnits == convertUnit.FeetToYard.ToString())
                {
                    return this.Ok(item);
                }
                else if (length.convertUnits==convertUnit.CentimeterToInch.ToString())
                {
                    return this.Ok(item);
                }
                else if (length.convertUnits == convertUnit.InchToCentimeter.ToString())
                {
                    return this.Ok(item);
                }
                else if (length.convertUnits == convertUnit.YardToFeet.ToString())
                {
                    return this.Ok(item);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
            }
        }
    }
}