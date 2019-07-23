using System;

namespace game
{
    public class Battle
    {
        IStyle currenttheme;
        public Battle(IStyle theme){
            currenttheme = theme;
        }
 
        public void StartFight(Warrior warrior1,
            Warrior warrior2)
        {

            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.BackgroundColor = currenttheme.BackgroundColor();
                    Console.ForegroundColor = currenttheme.ForegroundColor();
                    Console.WriteLine("Game Over");
                    Console.ResetColor(); 
                    break;
                }
 
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.BackgroundColor = currenttheme.BackgroundColor();
                    Console.ForegroundColor = currenttheme.ForegroundColor();
                    Console.WriteLine("Game Over");
                    Console.ResetColor(); 
                    break;
                }
            }
        }

        public string GetAttackResult(Warrior warriorA,
            Warrior warriorB)
        {

            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;
 

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.BackgroundColor = currenttheme.BackgroundColor();
            Console.ForegroundColor = currenttheme.ForegroundColor();
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                dmg2WarB);
                Console.ResetColor(); 

            Console.WriteLine("{0} Has {1} Health\n",
                warriorB.Name,
                warriorB.Health);
 
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n",
                    warriorB.Name,
                    warriorA.Name);
 
                return "Game Over";
            }
            else return "Fight Again";
        }
 
    }
}