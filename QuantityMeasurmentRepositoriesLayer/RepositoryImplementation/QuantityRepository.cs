
using Oracle.ManagedDataAccess.Client;
using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using QuantityMeasurmentRepositoriesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuantityMeasurmentRepositoriesLayer.RepositoryImplementation
{
    public class QuantityRepository : IQuantityRepository
    {
        public object CalculateLength(Length quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURE.Length(Feet ,Inch ,Yard ,Centimeter ,convertUnits ) values(:Feet,:Inch,:Yard,:Centimeter,:convertUnits)";
                using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    if (quantity.convertUnits == convertUnit.FeetToInch.ToString())
                    {
                        quantity.Inch = quantity.Feet * 12;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Inch;
                    }
                    else if (quantity.convertUnits == convertUnit.InchToFeet.ToString())
                    {
                        quantity.Feet = quantity.Inch / 12;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Feet;
                    }
                    else if (quantity.convertUnits == convertUnit.FeetToYard.ToString())
                    {
                        quantity.Feet = quantity.Yard / 3;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Feet;
                    }
                    else if (quantity.convertUnits == convertUnit.CentimeterToInch.ToString())
                    {
                        quantity.Inch = quantity.Centimeter / 2.54;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Inch;
                    }
                    else if (quantity.convertUnits == convertUnit.InchToCentimeter.ToString())
                    {
                        quantity.Centimeter = quantity.Inch * 2.54;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Centimeter;
                    }
                    else if (quantity.convertUnits.Equals(convertUnit.YardToFeet.ToString()))
                    {
                        quantity.Yard = quantity.Yard * 3;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Feet", quantity.Feet);
                        cmd.Parameters.Add("Inch", quantity.Inch);
                        cmd.Parameters.Add("Yard", quantity.Yard);
                        cmd.Parameters.Add("Centimeter", quantity.Centimeter);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Yard;
                    }
                    else
                    {
                        throw new CustomException("Options not matched", CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object CalculateTemperature(Temperature quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURE.Temperature(Fahrenheit ,Celsius ,convertUnits ) values(:Cselius ,:Fahrenheit ,:convertUnits)";
                using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    if (quantity.convertUnits == convertUnit.FahrenheitToCelsius.ToString())
                    {
                        quantity.Celsius = ((quantity.Fahrenheit - 32) * 5 / 9);
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Fahrenheit", quantity.Fahrenheit);
                        cmd.Parameters.Add("Celsius", quantity.Celsius);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Celsius;
                    }
                    else if (quantity.convertUnits == convertUnit.CelsiusToFahrenheit.ToString())
                    {
                        quantity.Fahrenheit = ((quantity.Celsius * 9 / 5) + 32);
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Fahrenheit", quantity.Fahrenheit);
                        cmd.Parameters.Add("Celsius", quantity.Celsius);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Fahrenheit;
                    }
                    else
                    {
                        throw new CustomException("Options not matched", CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object CalculateVolume(Volume quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURE.Volume(Liter ,Milliliter ,Gallon ,convertUnits ) values(:Liter,:Milliliter,:Gallon,:convertUnits)";
                using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    if (quantity.convertUnits == convertUnit.MililiterToLiter.ToString())
                    {
                        quantity.Liter = quantity.Milliliter / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Liter", quantity.Liter);
                        cmd.Parameters.Add("Milliliter", quantity.Milliliter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Liter;
                    }
                    else if (quantity.convertUnits == convertUnit.LiterToMiliter.ToString())
                    {
                        quantity.Milliliter = quantity.Liter * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Liter", quantity.Liter);
                        cmd.Parameters.Add("Milliliter", quantity.Milliliter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Milliliter;
                    }
                    else if (quantity.convertUnits == convertUnit.LiterToGallon.ToString())
                    {
                        quantity.Gallon = quantity.Liter / 3.785;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Liter", quantity.Liter);
                        cmd.Parameters.Add("Milliliter", quantity.Milliliter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Gallon;
                    }
                    else if (quantity.convertUnits == convertUnit.GallonToLiter.ToString())
                    {
                        quantity.Liter = quantity.Gallon * 3.785;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Liter", quantity.Liter);
                        cmd.Parameters.Add("Milliliter", quantity.Milliliter);
                        cmd.Parameters.Add("Gallon", quantity.Gallon);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Liter;
                    }
                    else
                    {
                        throw new CustomException("Options not matched", CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public object CalculateWeight(Weight quantity)
        {
            try
            {
                var commandText = "insert into QUANTITYMESURE.Weight(Kilogram ,Gram ,Tonne ,convertUnits ) values(:Kilogram,:Gram,:Tonne,:convertUnits)";
                using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
                using (OracleCommand cmd = new OracleCommand(commandText, _db))
                {
                    if (quantity.convertUnits == convertUnit.KgToGram.ToString())
                    {
                        quantity.Gram = quantity.Kilogram / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonne", quantity.Tonne);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Gram;
                    }
                    else if (quantity.convertUnits == convertUnit.GramToKg.ToString())
                    {
                        quantity.Kilogram = quantity.Gram * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonne", quantity.Tonne);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Kilogram;
                    }
                    else if (quantity.convertUnits == convertUnit.TonneToKg.ToString())
                    {
                        quantity.Tonne = quantity.Kilogram * 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonne", quantity.Tonne);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Tonne;
                    }
                    else if (quantity.convertUnits == convertUnit.KgToTanne.ToString())
                    {
                        quantity.Kilogram = quantity.Tonne / 1000;
                        cmd.Connection = _db;
                        cmd.Parameters.Add("Kilogram", quantity.Kilogram);
                        cmd.Parameters.Add("Gram", quantity.Gram);
                        cmd.Parameters.Add("Tonne", quantity.Tonne);
                        cmd.Parameters.Add("convertUnits", quantity.convertUnits);
                        _db.Open();
                        cmd.ExecuteNonQuery();
                        _db.Close();
                        return quantity.Kilogram;
                    }
                    else
                    {
                        throw new CustomException("Options not matched", CustomException.ExceptionType.OPTIONS_NOT_MATCH);
                    }
                }
            }
            catch (CustomException e)
            {
                throw new CustomException(e.Message, CustomException.ExceptionType.NULL_EXCEPTION);
            }
        }

        public void Connection()
        {
            Console.WriteLine("Starting.\r\n");
            using (var _db = new OracleConnection("User Id=system;Password=system;Data Source=localhost:1521/xe"))
            {
                Console.WriteLine("Open connection...");
                _db.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = _db;
                cmd.CommandText =
                "begin " +
                "  execute immediate 'create table  QUANTITYMESURE.Length(Feet FLOAT(8) ,Inch FLOAT(8) ,Yard FLOAT(8) ,Centimeter FLOAT(8),convertUnits varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURE.Temperature(Fahrenheit FLOAT(8) ,Celsius FLOAT(8) ,convertUnits varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURE.Volume(Liter FLOAT(8) , Milliliter FLOAT(8) ,Gallon FLOAT(8) ,convertUnits varchar2(20))';" +
                "  execute immediate 'create table  QUANTITYMESURE.Weight(Kilogram FLOAT(8) ,Gram FLOAT(8) ,Tonne FLOAT(8) ,convertUnits varchar2(20))';" +
               "end;";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                _db.Close();
            }
        }
    }
}