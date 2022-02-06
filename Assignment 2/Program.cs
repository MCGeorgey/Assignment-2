using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        private int value;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetConvertionData();
            program.ShowMenu();
            Console.ReadLine();
        }

        enum ConvertMenu
        {
            ConvertCelciusToFahrenheit = 1,
            ConvertCelciusToKelvin = 2,
            ConvertFahrenheitToCelcius = 3,
            ConvertFahrenheitToKelvin = 4,
            ConvertKelvinToCelcius = 5,
            ConvertKelvinToFahrenheit = 6,
            Exit = 7,
        }
        private void GetConvertionData()
        {
            int conversionValue = 0;
            string conversionData = string.Empty;
            do
            {
                Console.WriteLine("Please enter the value to be converted");
                conversionData = Console.ReadLine();
                if (!int.TryParse(conversionData, out conversionValue) && !conversionData.All(char.IsLetter))
                {
                    Console.WriteLine("Please enter an integer value\n");
                }
                else if (conversionData.All(char.IsLetter))
                {
                    Console.WriteLine("Please enter a valid number\n");
                }
                else if (int.Parse(conversionData) <= 0)
                {
                    Console.WriteLine("Please enter a valid number greater than 0\n");
                }
            } while (!int.TryParse(conversionData, out conversionValue) || int.Parse(conversionData) <= 0);
            value = conversionValue;
        }
        private void ShowMenu()
        {
            Boolean isContinue = false;
            var convertList = Enum.GetValues(typeof(ConvertMenu));
            int menuValue = 0;
            string menuData = string.Empty;
            do
            {
                foreach (ConvertMenu convert in convertList)
                {
                    Console.WriteLine("{0}: {1}", (int)convert, convert);
                }
                Console.WriteLine("Please choose any value from the above list");
                menuData = Console.ReadLine();
                if (menuData.All(char.IsLetter))
                {
                    Console.WriteLine("Please enter a valid number\n");
                }
                else if (int.Parse(menuData) <= 0 || int.Parse(menuData) > 7)
                {
                    Console.WriteLine("Please enter a valid number from the list\n");
                }
            } while (!int.TryParse(menuData, out menuValue) || (int.Parse(menuData) <= 0 || int.Parse(menuData) > 7)||isContinue);

            Conversion conversion = new Conversion(value);
            if (menuValue == (int)ConvertMenu.ConvertCelciusToFahrenheit)
            {
                conversion.DisplayData(conversion.ConvertCelciusToFahrenheit());
            }
            else if (menuValue == (int)ConvertMenu.ConvertCelciusToKelvin)
            {
                conversion.DisplayData(conversion.ConvertCelciusToKelvin());
            }
            else if (menuValue == (int)ConvertMenu.ConvertFahrenheitToCelcius)
            {
                conversion.DisplayData(conversion.ConvertFahrenheitToCelcius());
            }
            else if (menuValue == (int)ConvertMenu.ConvertFahrenheitToKelvin)
            {
                conversion.DisplayData(conversion.ConvertFahrenheitToKelvin());
            }
            else if (menuValue == (int)ConvertMenu.ConvertKelvinToCelcius)
            {
                conversion.DisplayData(conversion.ConvertkelvinToCelcius());
            }
            else if (menuValue == (int)ConvertMenu.ConvertKelvinToFahrenheit)
            {
               conversion.DisplayData( conversion.ConvertkelvinToFahrenheit());
            }
            else if(menuValue== (int)ConvertMenu.Exit)
            {
                isContinue = true;
            }
            if (!isContinue)
            {
                ShowMenu();
            }
        }
    }
}
