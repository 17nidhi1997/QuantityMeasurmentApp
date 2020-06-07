using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer
{
    public class Length
    {

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Feet { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Inch { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Yard { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public  double Centimeter { get; set; }
    }
}
