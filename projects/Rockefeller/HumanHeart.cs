using System;
namespace Rockefeller{
    public class HumanHeart:IHeart{

        private string PreviousOwnerName{get;set;}

        public void Connect(){
            Console.WriteLine("HumanHeart is connected");
            HeartRate = 80;
            PreviousOwnerName = "Jim Parson";
        }
        public string GetStatus(){
            return $"Human heart is Alive, PreviousOwnedName is {PreviousOwnerName} and HeartRate is {HeartRate}";
        }
        public double HeartRate{get;set;}
    }
}