using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class EnumData : System.Attribute
    {
        public enum CATEGORIES { 
        LENGTH,
        VOLUMES,
        WEIGHT,
        TEMPERATURE
        }

        public double value;
        public CATEGORIES category;
        public EnumData(double value, CATEGORIES category) {

            this.value = value;
            this.category = category;
        
        }
    }
}
