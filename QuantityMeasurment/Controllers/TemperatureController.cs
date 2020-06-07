using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;

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

        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public IActionResult CelsiusToFahrenheit(Temperature quantity)
        {
            var result = this._Manager.CelsiusToFahrenheit(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public IActionResult FahrenheitToCelsius(Temperature quantity)
        {
            var result = this._Manager.FahrenheitToCelsius(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}