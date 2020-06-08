using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentManagmentLayer.IManager;

namespace QuantityMeasurment.Controllers
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

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInch(Length quantity)
        {
            var result =this._Manager.FeetToInch(quantity);       
            return this.Ok(result);
        }

        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(Length quantity)
        {
            var result = this._Manager.InchToFeet(quantity);
            return this.Ok(result);
        }

        [Route("FeetToYard")]
        [HttpPost]
        public IActionResult FeetToYard(Length quantity)
        {
           var result = this._Manager.FeetToYard(quantity);
           return this.Ok(result);
        }

        [Route("YardToFeet")]
        [HttpPost]
        public IActionResult YardToFeet(Length quantity)
        {
           var result = this._Manager.YardToFeet(quantity);
           return this.Ok(result);
        }

        [Route("InchToCentimeter")]
        [HttpPost]
        public IActionResult InchToCentimeter(Length quantity)
        {
            var result = this._Manager.InchToCentimeter(quantity);
            return this.Ok(result);
        }

        [Route("CentimeterToInch")]
        [HttpPost]
        public IActionResult CentimeterToInch(Length quantity)
        {
            var result = this._Manager.CentimeterToInch(quantity);
            return this.Ok(quantity);
        }
    }
}