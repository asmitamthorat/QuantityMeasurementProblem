using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public enum Distance
    {
        Meters,
        Centimeters,
        Feet,
        Inches,
        Yards
    }
    public class LengthConversion
    {
        public static double[] conversionRate = new double[]
        {
        1,//meter
        100,//centimeter
        3.28,//feet
        39.37,//inches
        1.094//yards
        };

        public double ConvertMethod(double valueToConvert, Distance from, Distance to)
        {
            double ValueToWorkin;
            if (from == Distance.Meters)
            {
                ValueToWorkin = valueToConvert;
            }
            else
            {
                ValueToWorkin = valueToConvert / conversionRate[(int)from];
            }
            if (to != Distance.Meters)
            {
                ValueToWorkin = ValueToWorkin * conversionRate[(int)to];
            }
            return ValueToWorkin;
        }
       
    }
}
