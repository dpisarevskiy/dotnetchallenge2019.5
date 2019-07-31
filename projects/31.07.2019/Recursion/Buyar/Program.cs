using System;
using System.Linq;
using System.Collections.Generic;

namespace Buyar
{
    public class Battle{
        public static int AllWand{get;set;}
        public static int MaxWand{get;set;}
        public Player p1;
        public Player p2;

        public Battle(Player player1, Player player2, int a,int m){
            AllWand = a;
            MaxWand = m;
            this.p1 = player1;
            this.p2 = player2;
        }
        public void StartBattle(){
            Console.WriteLine(GetResult(p1, p2));
        }

        public string GetResult(Player player1, Player player2)
        {
            MaxWand = (AllWand-1) > MaxWand ? MaxWand : AllWand-1;
            int attack = player1.Bit(MaxWand);

            AllWand = AllWand - attack;
 
            Console.WriteLine($"{player1.Name} bit {attack} wand now count of wand is {AllWand}");

            if (AllWand <= 1)
            {
                Console.WriteLine($"{player1.Name} is Victorious\n");
                 return "Game Over";
            }
            else return GetResult(player2,player1);
        }
    }
    public class Player{
        public string Name{get;set;}
        public Random rnd = new Random();
        public Player(string n){
            Name = n;
        }

        public virtual int Bit(int MaxBit){
            int gamerBit = 0;
            Console.WriteLine($"Please enter value between 1 and {MaxBit}");
            int.TryParse(Console.ReadLine(),out gamerBit);
            if(!(gamerBit <= MaxBit && gamerBit >= 1)) {
                Console.WriteLine($"Wrong value {gamerBit}");
                gamerBit = Bit(MaxBit);
            }
            return gamerBit;
        }
    }

    public class PC:Player{
        public PC(string n):base(n){}
        public override int Bit(int MaxBit){
          //  if(Battle.AllWand % MaxBit != 1) {
            //  if(Battle.AllWand == 9){
          //        return 2;
          //    } else 
                return Enumerable.Range(1,MaxBit).Select(x => (Battle.AllWand - x) % (Battle.MaxWand+1) == 1 ? x : 1).Max();

        }
    }

        public class PCLow:Player{
        public PCLow(string n):base(n){}
        public override int Bit(int MaxBit){
            return rnd.Next(1,MaxBit+1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int AllWand = 20;
            int MaxWand = 3;
            Console.WriteLine("Please enter quantity of wands:");
            int.TryParse(Console.ReadLine(), out AllWand);
            Console.WriteLine("Please enter quantity per step:");
            int.TryParse(Console.ReadLine(), out MaxWand);

            Console.WriteLine("Enter name:");
            string name = "Dima";
            name = Console.ReadLine();

            Player player1 = new Player(name);
            Player player2 = new PC("PC1");
            
            Battle battle = new Battle(player1,player2, AllWand,MaxWand);
            battle.StartBattle();
            // int i = 0;
            // while(true){
            //     Battle.AllWand = AllWand;
            //     Battle.MaxWand = MaxWand;
            //     if(battle.GetResult(player1, player2)=="Game Over Dima") break;
            //     i++;
            // }
            // Console.WriteLine(i);

        }
    }
}