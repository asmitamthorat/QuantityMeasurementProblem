using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public enum Weight
    {
        kg,
        grams,
        tonne
    }
    public class WeightConversion
    {
        public static double[] conversionRate = new double[]
        {
                1,//kg
                1000,//grams
                0.001//tonne
        };

        public double ConvertMethod(double valueToConvert, Weight from, Weight to)
        {
            double ValueToWorkin;
            if (from == Weight.kg)
            {
                ValueToWorkin = valueToConvert;
            }
            else
            {
                ValueToWorkin = valueToConvert / conversionRate[(int)from];
            }
            if (to != Weight.kg)
            {
                ValueToWorkin = ValueToWorkin * conversionRate[(int)to];
            }
            return ValueToWorkin;

        }

        public double AdditionOfWeight(double element1, Weight firstElementUnit, double element2, Weight secondElementUnit) {

         
            return ConvertMethod(element1, firstElementUnit, Weight.kg) + ConvertMethod(element2, secondElementUnit, Weight.kg);
        }
    }
}
