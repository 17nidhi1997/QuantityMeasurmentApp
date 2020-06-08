using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using System;

namespace QuantityMeasurmentManagmentLayer.IManager
{
    /// <summary>
    /// Length(inch,feet,yard,centimeter)
    /// Tempareture(fahreheit,celsius
    /// Volume(mililiter,liter,gallon)
    /// Weight(kg,gram,tonne)
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns></returns>
    public interface IQuantityManager
    {
        ////Length
        object FeetToInch(Length quantity);
        object InchToFeet(Length quantity);
        object FeetToYard(Length quantity);
        object YardToFeet(Length quantity);
        object InchToCentimeter(Length quantity);
        object CentimeterToInch(Length quantity);

        ////Tempareture
        object FahrenheitToCelsius(Temperature quantity);
        object CelsiusToFahrenheit(Temperature quantity);

        ////Volume
        object MililiterToLiter(Volume quantity);
        object LiterToMiliter(Volume quantity);
        object LiterToGallon(Volume quantity);
        object GallonToLiter(Volume quantity);

        ////Weight
        object KgToGram(Weight quantity);
        object GramToKg(Weight quantity);
        object TonneToKg(Weight quantity);
        object KgToTanne(Weight quantity);
    }
}
