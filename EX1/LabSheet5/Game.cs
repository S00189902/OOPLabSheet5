using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
   public abstract class Game 
    {

        private readonly string _name;
        public  string Name { get;  set; }

        protected  decimal Price { get; set; }

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
            return string.Format($"{Name} will be released on {ReleaseDate.ToShortDateString()} and is selling for {Price}");

        }
        public virtual void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
        }
    }
}
