using System;
namespace Rockefeller{
    public class Rockefeller{
        private IHeart rheart;
        public IHeart Rheart{get{return rheart;}}
        public Rockefeller(){
            Console.WriteLine("Rockefeller is created with its own Heart that need to be replase");
            rheart = new HumanHeart();
            rheart.Connect();
        }

        public void InstallHeart(IHeart h){
            rheart = h;
            rheart.Connect();
        }
    }
}