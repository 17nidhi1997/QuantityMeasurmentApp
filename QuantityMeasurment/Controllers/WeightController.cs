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
    public class WeightController : ControllerBase
    {
            public IQuantityManager _Manager;
            public WeightController(IQuantityManager manager)
            {
                this._Manager = manager;
            }

            [Route("KgToGram")]
            [HttpPost]
            public IActionResult KgToGram(Weight quantity)
            {
                var result = this._Manager.KgToGram(quantity);
                if ((int)result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("GramToKg")]
            [HttpPost]
            public IActionResult GramToKg(Weight quantity)
            {
                var result = this._Manager.GramToKg(quantity);
                if ((int)result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

            [Route("TonneToKg")]
            [HttpPost]
            public IActionResult TonneToKg(Weight quantity)
            {
                var result = this._Manager.TonneToKg(quantity);
                if ((int)result >= 0)
                {
                    return this.Ok(result);
                }
                return this.BadRequest();
            }

        [Route("KgToTanne")]
        [HttpPost]
        public IActionResult KgToTanne(Weight quantity)
        {
            var result = this._Manager.KgToTanne(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}