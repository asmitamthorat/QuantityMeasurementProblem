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

        [Test]
        public void givenThreeFeet_whenEqual_ShouldReturnTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(3, Distance.Feet, Distance.Yards);
            Assert.AreEqual(1.00, output, 0.01);
        }

        [Test]
        public void givenoneFeetAndthreeInches_WhenToCompare_ReturnsTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(1, Distance.Feet, Distance.Inches);
            Assert.AreEqual(12.00, output, 0.01);

        }

        [Test]
        public void giventwoInches_WhenToCompare_ReturnsTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(2, Distance.Inches, Distance.Centimeters);
            Assert.AreEqual(5.08, output, 0.01);
        }

        [Test]
        public void givenInches_WhenAdded_ReturnsSum_InInches() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.AdditionOfLength(2, Distance.Inches, 3, Distance.Inches);
            Assert.AreEqual(5.00, output, 0.01);

        }
    }
}