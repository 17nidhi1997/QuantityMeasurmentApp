using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Volume
    {
        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Liter { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Milliliter { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Gallon { get; set; }
    }
}
