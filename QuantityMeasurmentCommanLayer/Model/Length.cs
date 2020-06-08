using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer
{
    public class Length
    {
        public double Feet { get; set; }
        public double Inch { get; set; }
        public double Yard { get; set; }
        public double Centimeter { get; set; }
    }
}
