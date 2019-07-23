using System;

namespace Rockefeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Rockefeller r = new Rockefeller();
              /* 
            IHeart human = new HumanHeart();
            IHeart tube = new TubeHeart();
            IHeart plastic = new PlasticHeart();
         
            r.InstallHeart(human);
            Console.WriteLine(human.GetStatus());
            r.InstallHeart(tube);
            Console.WriteLine(tube.GetStatus());
            r.InstallHeart(plastic);
            Console.WriteLine(plastic.GetStatus());
            */
            string s = "start";
            while(s != ""){
                Console.WriteLine();
                Console.WriteLine($"Please enter hearth HumanHeart, PlasticHeart, TubeHeart to replase");
                s = Console.ReadLine();
                switch(s){
                    case "HumanHeart":
                        r.InstallHeart(new HumanHeart());
                        Console.WriteLine(r.Rheart.GetStatus());
                        break;
                    case "PlasticHeart":
                        r.InstallHeart(new TubeHeart());
                     Console.WriteLine(r.Rheart.GetStatus());
                        break;
                    case "TubeHeart":
                        r.InstallHeart(new PlasticHeart());
                      Console.WriteLine(r.Rheart.GetStatus());
                        break;
                    default:
                        Console.WriteLine($"Nothing to do exit");
                        break;
                }
            }
        }
    }
}
