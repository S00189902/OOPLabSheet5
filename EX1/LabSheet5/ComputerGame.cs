using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet5
{
   public  class ComputerGame : Game
    {
        public string PEGI_rating { get; set; }

        public ComputerGame(string name,decimal price,DateTime releaseDate,string pegi): base(name,price,releaseDate)
        {
           
            PEGI_rating = pegi;
        }
        public ComputerGame()
        {

        }
        public override string ToString()
        {
            return string.Format($"{Name} will be released on {ReleaseDate.ToShortDateString()} and is selling for {Price} with a pegi rating of {PEGI_rating}");
        }

        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }
    }
}
