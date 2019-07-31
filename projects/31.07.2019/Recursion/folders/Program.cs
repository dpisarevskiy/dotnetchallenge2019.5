using System;
using System.IO;
using System.Collections;
using System.Linq;

namespace folders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dir = Recursion("C:\\Go");
            foreach(string s in dir.OrderBy(n => n))
                Console.WriteLine(s);
        }

        public static string[] Recursion(string dir){
        string [] sub = Directory.GetDirectories(dir);
        foreach(string subdirectory in sub)
            sub = sub.Concat(Recursion(subdirectory)).ToArray();
        return sub;
        }
    }
}
