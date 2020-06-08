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
            return this.Ok(result);
        }

        [Route("GramToKg")]
        [HttpPost]
        public IActionResult GramToKg(Weight quantity)
        {
            var result = this._Manager.GramToKg(quantity);
            return this.Ok(result);
        }
        
        [Route("TonneToKg")]
        [HttpPost]
        public IActionResult TonneToKg(Weight quantity)
        {      
            var result = this._Manager.TonneToKg(quantity);
            return this.Ok(result);
        }

        [Route("KgToTanne")]
        [HttpPost]
        public IActionResult KgToTanne(Weight quantity)
        {
            var result = this._Manager.KgToTanne(quantity);
            return this.Ok(result);
        }
    }
}