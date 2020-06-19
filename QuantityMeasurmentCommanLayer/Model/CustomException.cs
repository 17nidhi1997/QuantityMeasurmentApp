using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentCommanLayer.Model
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            OPTIONS_NOT_MATCH, 
            NULL_EXCEPTION, 
            NULL_INPUT
        }
        public ExceptionType type;
        public CustomException(ExceptionType type)
        {
            this.type = type;
        }
        public CustomException(String message, ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}

