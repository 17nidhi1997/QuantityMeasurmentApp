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
        ////Length
        Object FeetToInch(Length quantity);
        Object InchToFeet(Length quantity);
        Object FeetToYard(Length quantity);
        Object YardToFeet(Length quantity);
        Object InchToCentimeter(Length quantity);
        Object CentimeterToInch(Length quantity);

        ////Tempareture
        Object FahrenheitToCelsius(Temperature quantity);
        Object CelsiusToFahrenheit(Temperature quantity);

        ////Volume
        Object MililiterToLiter(Volume quantity);
        Object LiterToMiliter(Volume quantity);
        Object LiterToGallon(Volume quantity);
        Object GallonToLiter(Volume quantity);

        ////Weight
        Object KgToGram(Weight quantity);
        Object GramToKg(Weight quantity);
        Object TonneToKg(Weight quantity);
        Object KgToTanne(Weight quantity);
    }
}
