using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentManagmentLayer.IManager;
using QuantityMeasurmentRepositoriesLayer.Repository;
using QuantityMeasurmentRepositoriesLayer.RepositoryImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentManagmentLayer.ManagerImplemantation
{
    public class QuantityManagerImplemantation : IQuantityManager
    {
        private IQuantityRepository _quantity;
        public QuantityManagerImplemantation(IQuantityRepository quantitys)
        {
            _quantity = quantitys;
        }
        public object CalculateLength(Length quantity)
        {
            return this._quantity.CalculateLength(quantity);
        }
        public object CalculateTemperature(Temperature quantity)
        {
            return this._quantity.CalculateTemperature(quantity);
        }         
        public object CalculateVolume(Volume quantity)
        {
            return this._quantity.CalculateVolume(quantity);
        }
        public object CalculateWeight(Weight quantity)
        {
            return this._quantity.CalculateWeight(quantity);
        }
    }
}
