using System;
namespace Challenge2
{
    public class WeatherData
    {
        private double _temperature;
        public double Temperature
        {
            get {
                return _temperature;
            }
            set {
                if (value >= -60 && value <= 60)
                {
                    _temperature = value;
                }
                else {
                    Console.WriteLine("A reading mistake must have been made, please try again");
                    double.TryParse(Console.ReadLine(), out _temperature);
                    Temperature = _temperature;
                }
            }
        }
  
        private int _humidity;
        public int Humidity
        {
            get {
                return _humidity;
            }
            set {
                if (value >= 0 && value <= 100)
                {
                    _humidity = value;
                }
                else
                {
                    Console.WriteLine("A reading mistake must have been made, please try again");
                    int.TryParse(Console.ReadLine(), out _humidity);
                    Humidity = _humidity;
                }
            }
        }

        private string _scale;
        public string Scale
        {
            get {
                return _scale;
            }
            set {
                if (value.ToUpper() == "F") {
                    Console.WriteLine($"Converted Temperature is {convert()}°F with Humidity at {_humidity}%");
                }
            }
        }

        double convert() {
            return Math.Round(_temperature * (9.0 / 5.0) + 32.0, 2);
        }
    }
}

