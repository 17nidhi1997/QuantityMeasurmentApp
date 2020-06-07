using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using System;

namespace QuantityMeasurmentManagmentLayer.IManager
{
    public interface IQuantityManager
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
