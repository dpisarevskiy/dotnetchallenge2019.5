namespace Proxy
{
    public class TemperaturePredictor
    {
        public ICalculator Calculator { get; set; }

        public double PredictTemperature()
        {
            return Calculator.CalcWind() * Calculator.CalcClouds();
        }
    }
}