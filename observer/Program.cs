using System;
namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Weather Application using Observer Pattern");
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay( weatherData );
            weatherData.setMeasurementsChanged( new WeatherDataDomain( 10,50,100 ) );
        }
    }
}