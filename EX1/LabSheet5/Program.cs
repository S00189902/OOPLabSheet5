using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Game g1 = new Game("Monster Hunter 4 Ultimate", 45.00m, new DateTime(2015, 06, 06));

           // Game g2 = new Game() { ReleaseDate = new DateTime(2019, 8, 25) };

          //  Console.WriteLine(g1);
           // Console.WriteLine(g2);

            ComputerGame cg1 = new ComputerGame("Outer Worlds", 45.00m, new DateTime(2019, 10, 25),"18");
            ComputerGame cg2 = new ComputerGame("CyberPunk 2077",69.99m, new DateTime(2020, 4, 26), "18");

            Console.WriteLine(cg1);
            Console.WriteLine(cg2);

            DisplayGame(cg1);
            DisplayGame(cg2);
        }
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
