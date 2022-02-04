using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Conversion
    {
        private int conversionValue;

        public int ConversionValue { get => conversionValue; set => conversionValue = value; }

        public Conversion(int conversionValue)
        {
            this.ConversionValue = conversionValue;
        }

        public Conversion()
        {
            this.ConversionValue = 1;
        }
        public double ConvertCelciusToFahrenheit()
        {
            return (conversionValue * 1.800) + 32;
        }
        public double ConvertCelciusToKelvin()
        {
            return conversionValue + 273.15;
        }
        public double ConvertkEvinToFahrenheit()
        {
            return ((conversionValue - 273.15) * 1.8) + 32;
        }
        public double ConvertkEvinToCelcius()
        {
            return (conversionValue - 273.15);
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (conversionValue + 459.67) * .556;
        }
        public double ConvertFahrenheitToCelcius()
        {
            return (conversionValue - 32) / 1.8;
        }
    }
}
