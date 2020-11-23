using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class Tests
    {
       

        [Test]
        public void GivenMeter_WhenEqual_ShouldReturnTrue()
        {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }

        [Test]
        public void GivenFeet_WhenEqual_ShouldReturnTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(0.0, Distance.Feet, Distance.Feet);
            Assert.AreEqual(0.0, output);

        }
    }
}