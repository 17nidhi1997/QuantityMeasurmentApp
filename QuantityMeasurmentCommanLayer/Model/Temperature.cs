﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class Temperature
    {
       public double Fahrenheit { get; set; }
       public double Celsius { get; set; }
       public string convertUnits { get; set; }
    }
}
