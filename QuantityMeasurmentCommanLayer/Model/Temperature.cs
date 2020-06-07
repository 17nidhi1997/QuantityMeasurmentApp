using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Temperature
    {
      
       [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Fahrenheit { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?")]
        public double Celsius { get; set; }
    }
}
