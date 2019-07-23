using System;
namespace Rockefeller{
    public class TubeHeart:IHeart{

        private decimal Price{get;set;}

        public void Connect(){
            Console.WriteLine("TubeHeart is connected");
            HeartRate = 4;
            Price = 1000000;
        }
        public string GetStatus(){
            return $"Human heart is Alive, Heart Price is {Price} USD and HeartRate is {HeartRate}Mhz";
        }
        public double HeartRate{get;set;}
    }
}