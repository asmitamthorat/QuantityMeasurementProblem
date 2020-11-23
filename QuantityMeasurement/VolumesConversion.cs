using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{

    public enum Volumes
    {
        litre,
        gallon,
        millititres
    }
    public class VolumesConversion
    {
        public static double[] conversionRate = new double[]
       {
        1,//litre
       0.26,//gallon
       1000//feet   
       };

        public double ConvertMethod(double valueToConvert, Volumes from, Volumes to)
        {
            double ValueToWorkin;
            if (from == Volumes.litre)
            {
                ValueToWorkin = valueToConvert;
            }
            else
            {
                ValueToWorkin = valueToConvert / conversionRate[(int)from];
            }
            if (to != Volumes.litre)
            {
                ValueToWorkin = ValueToWorkin * conversionRate[(int)to];
            }
            return ValueToWorkin;
        }

        public double AdditionOfVolumes(double element1, Volumes firstElementUnit, double element2, Volumes secondElementUnit) { 
       
        return ConvertMethod(element1, firstElementUnit, Volumes.litre)+ ConvertMethod(element2, secondElementUnit, Volumes.litre);
        }
    }
}
