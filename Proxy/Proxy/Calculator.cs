using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Proxy
{
    public class WeatherStateCalculator : ICalculator
    {
        public double CalcClouds()
        {
            Thread.Sleep(1000);

            return 4;
        }

        public double CalcWind()
        {
            Thread.Sleep(500);
            return 8;
        }
    }
}