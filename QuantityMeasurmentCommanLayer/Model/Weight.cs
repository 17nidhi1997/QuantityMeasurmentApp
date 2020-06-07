using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Weight
    {

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Kilogram { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Gram { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Tonne { get; set; }
    }
}
