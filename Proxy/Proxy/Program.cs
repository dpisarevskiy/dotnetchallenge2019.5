using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturePredictor predictor = new TemperaturePredictor();
            predictor.Calculator = new FileLogWeatherStateCalculator(new WeatherStateCalculator());

            var temperature = predictor.PredictTemperature();
            Console.WriteLine(temperature);
        }
    }
}
