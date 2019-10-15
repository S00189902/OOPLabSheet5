using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
   static class Program
    {
        static void Main(string[] args)
        {
            int result = 23.By2Less1();
            Console.WriteLine(result);

            string text = "This is a test sentence";

            Console.WriteLine("The number of works in \"{0}\" is {1}", text, text.WordCount());
        }
        public static int By2Less1(this int num)
        {
            return num * 2 - 1;
        }

        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
