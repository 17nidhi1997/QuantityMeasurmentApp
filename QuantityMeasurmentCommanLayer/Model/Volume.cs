using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Volume
    {
        public double Liter { get; set; }
        public double Milliliter { get; set; }
        public double Gallon { get; set; }
    }
}
