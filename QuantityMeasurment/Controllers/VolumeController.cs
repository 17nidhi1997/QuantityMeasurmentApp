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
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("LiterToMiliter")]
        [HttpPost]
        public IActionResult LiterToMiliter(Volume quantity)
        {
            var result = this._Manager.LiterToMiliter(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MililiterToLiter")]
        [HttpPost]
        public IActionResult MililiterToLiter(Volume quantity)
        {
            var result = this._Manager.MililiterToLiter(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("GallonToLiter")]
        [HttpPost]
        public IActionResult GallonToLiter(Volume quantity)
        {
            var result = this._Manager.GallonToLiter(quantity);
            if ((int)result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}