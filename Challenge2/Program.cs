using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            int humi;

            WeatherData myWeather = new WeatherData();

            Console.WriteLine("Please enter your current temperature:");
            double.TryParse(Console.ReadLine(), out temp);
            myWeather.Temperature = temp;

            Console.WriteLine("Please enter your current humidity:");
            int.TryParse(Console.ReadLine(), out humi);
            myWeather.Humidity = humi;

            Console.WriteLine("Your current weather conditions have been saved.");
            Console.WriteLine($"Temperature at {myWeather.Temperature}°C and Humidity at {myWeather.Humidity}%");

            Console.WriteLine("Type in 'F' in the command line if you would like to convert the temperature to Fahrenheit");
            myWeather.Scale = Console.ReadLine();

            Console.WriteLine("Program finished.");

        }
    }
}