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
    public class VolumeController : ControllerBase
    {
        public IQuantityManager _Manager;
        public VolumeController(IQuantityManager manager)
        {
            this._Manager = manager;
        }

        [HttpPost]
        [Route("CalculateVolume")]
        public IActionResult CalculateVolume(Volume quantity)
        {
            var item = _Manager.CalculateVolume(quantity);
            try
            {
                if (quantity.convertUnits == convertUnit.MililiterToLiter.ToString())
                {
                    return this.Ok(new
                    {
                        result = item
                    });
                }
                else if (quantity.convertUnits == convertUnit.LiterToMiliter.ToString())
                {
                    return this.Ok(new
                    {
                        result = item
                    });
                }
                else if (quantity.convertUnits == convertUnit.LiterToGallon.ToString())
                {
                    return this.Ok(new
                    {
                        result = item
                    });
                }
                else if (quantity.convertUnits == convertUnit.GallonToLiter.ToString())
                {
                    return this.Ok(new
                    {
                        result = item
                    });
                }
                else
                {
                    return this.BadRequest(new
                    {
                        result = "Error in connection"
                    });
                }
            }
            catch (CustomException)
            {
                return BadRequest(CustomException.ExceptionType.OPTIONS_NOT_MATCH);
            }
        }
    }
}