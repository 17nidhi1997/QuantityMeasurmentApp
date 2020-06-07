using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentManagmentLayer.ManagerImplemantation
{
    public class QuantityManagerImplemantation : IQuantityManager
    {
        private IQuantityManager _quantity;
        public QuantityManagerImplemantation(IQuantityManager quantitys)
        {
            _quantity = quantitys;
        }
        public object CelsiusToFahrenheit(Temperature quantity)
        {
            return this._quantity.CelsiusToFahrenheit(quantity);
        }

        public object CentimeterToInch(Length quantity)
        {
            return this._quantity.CentimeterToInch(quantity);
        }

        public object FahrenheitToCelsius(Temperature quantity)
        {
            return this._quantity.FahrenheitToCelsius(quantity);
        }

        public object FeetToInch(Length quantity)
        {
            return this._quantity.FeetToInch(quantity);
        }

        public object FeetToYard(Length quantity)
        {
            return this._quantity.FeetToYard(quantity);
        }

        public object GallonToLiter(Volume quantity)
        {
            return this._quantity.GallonToLiter(quantity);
        }

        public object GramToKg(Weight quantity)
        {
            return this._quantity.GramToKg(quantity);
        }

        public object InchToCentimeter(Length quantity)
        {
            return this._quantity.InchToCentimeter(quantity);
        }

        public object InchToFeet(Length quantity)
        {
            return this._quantity.InchToFeet(quantity);
        }

        public object KgToGram(Weight quantity)
        {
            return this._quantity.KgToGram(quantity);
        }

        public object KgToTanne(Weight quantity)
        {
            return this._quantity.KgToTanne(quantity);
        }

        public object LiterToGallon(Volume quantity)
        {
            return this._quantity.LiterToGallon(quantity);
        }

        public object LiterToMiliter(Volume quantity)
        {
            return this._quantity.LiterToMiliter(quantity);
        }

        public object MililiterToLiter(Volume quantity)
        {
            return this._quantity.MililiterToLiter(quantity);
        }

        public object TonneToKg(Weight quantity)
        {
            return this._quantity.TonneToKg(quantity);
        }

        public object YardToFeet(Length quantity)
        {
            return this._quantity.YardToFeet(quantity);
        }
    }
}
