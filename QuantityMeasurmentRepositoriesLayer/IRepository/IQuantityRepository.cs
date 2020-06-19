using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepositoriesLayer.Repository
{
    /// <summary>
    /// Length(inch,feet,yard,centimeter)
    /// Tempareture(fahreheit,celsius
    /// Volume(mililiter,liter,gallon)
    /// Weight(kg,gram,tonne)
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns></returns>
    public interface IQuantityRepository
    {
       // void Connection();
        object CalculateLength(Length quantity);
        object CalculateTemperature(Temperature quantity);
        object CalculateWeight(Weight quantity);
        object CalculateVolume(Volume quantity);
    }
}
