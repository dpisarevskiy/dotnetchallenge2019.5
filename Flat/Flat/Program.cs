using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter flat style: (light or dark)");
            string flatStyle = Console.ReadLine();
            
            Flat flat = new Flat();

            //todo
            IRoomFactory factory = CreateFactory(flatStyle);

            flat.Room1 = factory.CreateRoom();
            flat.Room2 = factory.CreateRoom();
            flat.Balcony = factory.CreateBalcony();

        }

        private static IRoomFactory CreateFactory(string flatStyle)
        {
            if (string.Equals(flatStyle, "light", StringComparison.OrdinalIgnoreCase))
                return new LightRoomFactory();
            else if (string.Equals(flatStyle, "dark", StringComparison.OrdinalIgnoreCase))
                return new DarkRoomFactory();

            return null;
        }
    }
}
