using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public enum Temparature
    {
        celsius,
        Faherenheit
    }


    public class TemperatureConversion
    {
        public double tempConversion(double tempature, Temparature from, Temparature to)
        {
            double ValueToWorkin;
            if (to == Temparature.celsius)
            {
                ValueToWorkin = tempature / 2.12;
            }
            else
            {
                ValueToWorkin = tempature / 0.471;
            }
            return ValueToWorkin;
        }
    }
}
