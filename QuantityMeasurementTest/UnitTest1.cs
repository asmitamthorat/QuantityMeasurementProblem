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
        public void GivenThreeFeet_whenEqual_ShouldReturnTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(3, Distance.Feet, Distance.Yards);
            Assert.AreEqual(1.00, output, 0.01);
        }

        [Test]
        public void GivenoneFeetAndthreeInches_WhenToCompare_ReturnsTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(1, Distance.Feet, Distance.Inches);
            Assert.AreEqual(12.00, output, 0.01);

        }

        [Test]
        public void GiventwoInches_WhenToCompare_ReturnsTrue() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.ConvertMethod(2, Distance.Inches, Distance.Centimeters);
            Assert.AreEqual(5.08, output, 0.01);
        }

        [Test]
        public void GivenInches_WhenAdded_ReturnsSum_InInches() {
            LengthConversion conversion = new LengthConversion();
            double output = conversion.AdditionOfLength(2, Distance.Inches, 3, Distance.Inches);
            Assert.AreEqual(5.00, output, 0.01);
        }

        [Test]
        public void GivenGallon_whenEqual_shouldReturnTrue() {
            VolumesConversion conversionVolumes = new VolumesConversion();
            double output = conversionVolumes.ConvertMethod(1, Volumes.gallon, Volumes.litre);
            Assert.AreEqual(3.84, output, 0.01);

        }

        [Test]
        public void GivenValuesinGallonLitre_shouldReturnAddition() {
            VolumesConversion conversionVolumes = new VolumesConversion();
            double output = conversionVolumes.AdditionOfVolumes(1, Volumes.gallon, 3.78, Volumes.litre);
            Assert.AreEqual(7.62, output, 0.01);

        }

        [Test]
        public void GivenValuesInTonneAndGrames_ShouldReturnAddition() {
            WeightConversion weightConversion = new WeightConversion();
            double output = weightConversion.AdditionOfWeight(1, Weight.tonne, 1000, Weight.grams);
            Assert.AreEqual(1001, output, 0.01);

        }

        [Test]
        public void GivenTemperatureinFaherenheit_shouldConvertintoCelsius() {
            TemperatureConversion temperatureConversion = new TemperatureConversion();
            double output = temperatureConversion.tempConversion(212, Temparature.Faherenheit, Temparature.celsius);
            Assert.AreEqual(100, output, 0.01);
        
        }
    }
}