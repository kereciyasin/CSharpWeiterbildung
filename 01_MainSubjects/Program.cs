using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Projenin Ismidir */
namespace _01_MainSubjects
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Write("Hello Leute!");
            //Console.WriteLine("Hello World!");  

            //Console.WriteLine("******* Sprache *******");
            //Console.WriteLine();
            //Console.WriteLine("1.C#");
            //Console.WriteLine("2.JS");
            //Console.WriteLine("3.Pyhton");
            //Console.WriteLine("4.C++");
            //Console.WriteLine("5.Html/Css");
            //Console.WriteLine("6.Java");

            #region String Variables

            //string
            //string name;
            //name = "Yasin";
            //Console.WriteLine(name);


            //camelCase
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Yasin";
            //customerSurname = "Kara";
            //customerPhone = "1234567890";
            //customerEmail = "kara@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Reservation Kart ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Custormer Name: " + customerName);
            //Console.WriteLine("Custormer Surname: " + customerSurname);
            //Console.WriteLine("Custormer Phone: " + customerPhone);
            //Console.WriteLine("Custormer Email: " + customerEmail);
            //Console.WriteLine("Custormer District: " + district);
            //Console.WriteLine("Custormer City: " + city);
            //Console.WriteLine("---------------------------------------");





            #endregion


            #region Int Variables

            //int 
            //int number = 24;*/
            //Console.WriteLine(number);

            int hamburgerPrice = 20;
            int cokePrice = 5;
            int waterPrice = 2;
            int friesPrice = 8;
            int pizzaPrice = 30;
            int lemonadePrice = 7;

            Console.WriteLine("***** Menu ******");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " CH");
            Console.WriteLine("-----Coke: " + cokePrice + " CH");
            Console.WriteLine("-----Water: " + waterPrice + " CH");
            Console.WriteLine("-----Fries: " + friesPrice + " CH");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " CH");
            Console.WriteLine("-----Lemonade: " + lemonadePrice + " CH");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHammurgerAmount = 0;
            int totalCokeAmount = 0;
            int totalWaterAmount = 0;
            int totalFriesAmount = 0;
            int totalPizzaAmount = 0;
            int totalLemonadeAmount = 0;


            hamburgerCount = 2;
            cokeCount = 1;
            waterCount = 1;
            friesCount = 1;
            pizzaCount = 3;
            lemonadeCount = 2;
            totalHammurgerAmount = hamburgerCount * hamburgerPrice;
            totalCokeAmount = cokeCount * cokePrice;
            totalWaterAmount = waterCount * waterPrice;
            totalFriesAmount = friesCount * friesPrice;
            totalPizzaAmount = pizzaCount * pizzaPrice;
            totalLemonadeAmount = lemonadeCount * lemonadePrice;
            int totalAmount = totalHammurgerAmount + totalCokeAmount + totalWaterAmount + totalFriesAmount + totalPizzaAmount + totalLemonadeAmount;    


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-----Hamburger: " + totalHammurgerAmount + " CH");
            Console.WriteLine("-----Coke: " + totalCokeAmount + " CH");
            Console.WriteLine("-----Water: " + totalWaterAmount + " CH");
            Console.WriteLine("-----Fries: " + totalFriesAmount + " CH");
            Console.WriteLine("-----Pizza: " + totalPizzaAmount + " CH");
            Console.WriteLine("-----Lemonade: " + totalLemonadeAmount + " CH");
            Console.WriteLine("-----Amount: " + totalAmount + " CH");
            Console.WriteLine("---------------------------------------");



            #endregion
            Console.ReadLine();
        }
    }
}
