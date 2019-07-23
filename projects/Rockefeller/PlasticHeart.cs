using System;
namespace Rockefeller{
     public class PlasticHeart:IHeart{

        private string SerialNumber{get;set;}

        public void Connect(){
            Console.WriteLine("PlasticHeart is connected");
            HeartRate = 0;
            SerialNumber = "000001";
        }
        public string GetStatus(){
            return $"Human heart is Alive, SerialNumber is {SerialNumber} and HeartRate is {HeartRate}";
        }
        public double HeartRate{get;set;}
    }
}