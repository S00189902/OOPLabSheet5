using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
    class Game
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }



        public Game(string name, decimal price, DateTime dateOfRelease)
        {
            Name = name;

            Price = price;

            ReleaseDate = dateOfRelease;

        }

        public Game(string name, decimal price):this(name,price,DateTime.Now)
        {

        }
        public Game() : this("N/A",0)
        {

        }

          public override string ToString()
        {
            return string.Format($"{Name} will be released on {ReleaseDate} and is selling for {Price}");

        }
    }
}
