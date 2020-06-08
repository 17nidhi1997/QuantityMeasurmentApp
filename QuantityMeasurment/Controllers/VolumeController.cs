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
    public class VolumeController : ControllerBase
    {
        public IQuantityManager _Manager;
        public VolumeController(IQuantityManager manager)
        {
            this._Manager = manager;
        }

        [Route("LiterToGallon")]
        [HttpPost]
        public IActionResult LiterToGallon(Volume quantity)
        {
            var result = this._Manager.LiterToGallon(quantity);
            return this.Ok(result);
        }

        [Route("LiterToMiliter")]
        [HttpPost]
        public IActionResult LiterToMiliter(Volume quantity)
        {
            var result = this._Manager.LiterToMiliter(quantity);
            return this.Ok(result);
        }

        [Route("MililiterToLiter")]
        [HttpPost]
        public IActionResult MililiterToLiter(Volume quantity)
        {
            var result = this._Manager.MililiterToLiter(quantity);
            return this.Ok(result);
        }

        [Route("GallonToLiter")]
        [HttpPost]
        public IActionResult GallonToLiter(Volume quantity)
        {
            var result = this._Manager.GallonToLiter(quantity);
            return this.Ok(result);
        }
    }
}