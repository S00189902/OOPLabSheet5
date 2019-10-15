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
            Game g1 = new Game("Monster Hunter 4 Ultimate", 45.00m, new DateTime(2015, 06, 06));

            Game g2 = new Game() { Price = 25.00m, ReleaseDate = new DateTime(2019, 8, 25) };
        }
    }
}
