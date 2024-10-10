using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double

            //double
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("***** Price List ******");
            Console.WriteLine();

            double applePrice, bananaPrice, orangePrice, watermelonPrice, melonPrice;
            applePrice = 4.85;
            bananaPrice = 3.45;
            orangePrice = 2.65;
            watermelonPrice = 5.25;
            melonPrice = 6.75;

            Console.WriteLine("-----Apple Price: " + applePrice);
            Console.WriteLine("-----Banana Price: " + bananaPrice);
            Console.WriteLine("-----Orange Price: " + orangePrice);
            Console.WriteLine("-----Watermelon Price: " + watermelonPrice);
            Console.WriteLine("-----Melon Price: " + melonPrice);



            #endregion
            Console.Read();
        }
    }
}
