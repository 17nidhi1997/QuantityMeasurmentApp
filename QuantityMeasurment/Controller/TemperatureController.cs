using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;
using Serilog;

namespace QuantityMeasurment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        public IQuantityManager _Manager;
        public TemperatureController(IQuantityManager manager)
        {
            this._Manager = manager;
        }

        [HttpPost]
        [Route("CalculateTemperature")]
        public IActionResult CalculateTemperature(Temperature quantity)
        {
            var item = _Manager.CalculateTemperature(quantity);
            try
            {
                if (quantity.convertUnits == convertUnit.FahrenheitToCelsius.ToString())
                {
                    return this.Ok(item);
                }
                else if (quantity.convertUnits == convertUnit.CelsiusToFahrenheit.ToString())
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