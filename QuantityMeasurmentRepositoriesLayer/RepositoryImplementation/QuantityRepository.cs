using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentRepositoriesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepositoriesLayer.RepositoryImplementation
{
    public class QuantityRepository :IQuantityRepository
    {
        public object FeetToInch(Length quantity)
        {
            return quantity.Feet * 12;
        }
        public object FeetToYard(Length quantity)
        {
            return quantity.Yard /3;
        }
        public object CentimeterToInch(Length quantity)
        {
            return quantity.Centimeter / 2.54;
        }
        public object InchToCentimeter(Length quantity)
        {
            return quantity.Inch * 2.54;
        }
        public object InchToFeet(Length quantity)
        {
            return quantity.Inch / 12;
        }
        public object YardToFeet(Length quantity)
        {
            return quantity.Yard *3;
        }
        public object FahrenheitToCelsius(Temperature quantity)
        {
            return ((quantity.Fahrenheit - 32) *5 / 9 );
        }
        public object CelsiusToFahrenheit(Temperature quantity)
        {
            return ((quantity.Celsius * 9/5)+32);
        }
        public object MililiterToLiter(Volume quantity)
        {
            return quantity.Milliliter /1000;
        }
        public object LiterToMiliter(Volume quantity)
        {
            return quantity.Liter * 1000;
        }
        public object LiterToGallon(Volume quantity)
        {
            return quantity.Liter /3.785;
        }
        public object GallonToLiter(Volume quantity)
        {
            return quantity.Gallon * 3.785;
        }
        public object KgToGram(Weight quantity)
        {
            return quantity.Kilogram/1000;
        }
        public object GramToKg(Weight quantity)
        {
            return quantity.Gram * 1000;
        }
        public object TonneToKg(Weight quantity)
        {
            return quantity.Kilogram * 1000;
        }
        public object KgToTanne(Weight quantity)
        {
            return quantity.Tonne / 1000;
        }
    }
}