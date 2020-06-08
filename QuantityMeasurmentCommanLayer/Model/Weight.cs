using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Weight
    {
        public double Kilogram { get; set; }
        public double Gram { get; set; }
        public double Tonne { get; set; }
    }
}
