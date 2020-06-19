using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;
using Serilog;

namespace QuantityMeasurment.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        public IQuantityManager _Manager;
        public WeightController(IQuantityManager manager)
        {
            this._Manager = manager;
        }

        [HttpPost]
        [Route("CalculateWeight")]
        public IActionResult CalculateWeight(Weight quantity)
        {
            var item = _Manager.CalculateWeight(quantity);
            try
            {
                if (quantity.convertUnits == convertUnit.KgToGram.ToString())
                {
                    return this.Ok(item);
                }
                else if (quantity.convertUnits == convertUnit.GramToKg.ToString())
                {
                    return this.Ok(item);
                }
                else if (quantity.convertUnits == convertUnit.TonneToKg.ToString())
                {
                    return this.Ok(item);
                }
                else if (quantity.convertUnits == convertUnit.KgToTanne.ToString())
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