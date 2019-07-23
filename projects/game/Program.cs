using System;

namespace game
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine("Please input possible theme: Style1, Style2 or own");
            string theme = Console.ReadLine();
           // Console.WriteLine(typeof(Style1).AssemblyQualifiedName);

           //By annotation 
           //IStyle style = GetInstance(theme);
            
            //by Abstract Fabric

            IStyleFactory sf = new StyleFactory();
            IStyle style = sf.GetStyle(theme);

            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Battle b = new Battle(style);

            b.StartFight(maximus, bob);
        }

        public static IStyle GetInstance(string FullyQualifiedNameOfClass)
        {         //game.Style1, game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
            string objectToInstantiate = $"game.{FullyQualifiedNameOfClass}, game";
            try{ 
            return Activator.CreateInstance(Type.GetType(objectToInstantiate)) as IStyle;
            } catch {
                Console.WriteLine("error ocurr used default Style1");
                return new Style1();
            }
        }
    }
}