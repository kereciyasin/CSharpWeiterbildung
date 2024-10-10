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

            //Console.WriteLine("***** Price List ******");
            //Console.WriteLine();

            //double applePrice, bananaPrice, orangePrice, watermelonPrice, melonPrice;
            //applePrice = 4.85;
            //bananaPrice = 3.45;
            //orangePrice = 2.65;
            //watermelonPrice = 5.25;
            //melonPrice = 6.75;

            //Console.WriteLine("-----Apple Price: " + applePrice + " CH");
            //Console.WriteLine("-----Banana Price: " + bananaPrice + " CH");
            //Console.WriteLine("-----Orange Price: " + orangePrice + " CH");
            //Console.WriteLine("-----Watermelon Price: " + watermelonPrice + " CH");
            //Console.WriteLine("-----Melon Price: " + melonPrice + "  CH");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleKg, bananaKg, orangeKg, watermelonKg, melonKg;
            //appleKg = 2.5;
            //bananaKg = 3.5;
            //orangeKg = 4.5;
            //watermelonKg = 5.5;
            //melonKg = 6.5;

            //double appleTotal, bananaTotal, orangeTotal, watermelonTotal, melonTotal;
            //appleTotal = applePrice * appleKg;
            //bananaTotal = bananaPrice * bananaKg;
            //orangeTotal = orangePrice * orangeKg;
            //watermelonTotal = watermelonPrice * watermelonKg;
            //melonTotal = melonPrice * melonKg;


            //Console.WriteLine("Product Received: Apple - " + "Price: " + applePrice + " - Kg " + appleKg + " - Total: " + appleTotal);
            //Console.WriteLine("Product Received: Banana - " + "Price: " + bananaPrice + " - Kg " + bananaKg + " - Total: " + bananaTotal);
            //Console.WriteLine("Product Received: Orange - " + "Price: " + orangePrice + " - Kg " + orangeKg + " - Total: " + orangeTotal);
            //Console.WriteLine("Product Received: Watermelon - " + "Price: " + watermelonPrice + " - Kg " + watermelonKg + " - Total: " + watermelonTotal);
            //Console.WriteLine("Product Received: Melon - " + "Price: " + melonPrice + " - Kg " + melonKg + " - Total: " + melonTotal);

            //double totalPrice;
            //totalPrice = appleTotal + bananaTotal + orangeTotal + watermelonTotal + melonTotal;
            //Console.WriteLine("Total Price: " + totalPrice + " CH");


            #endregion

            #region char

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);



            #endregion

            #region Data input from the keyboard
            //Console.WriteLine("***** Passenger Information ******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistricht, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Enter your name: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Enter your surname: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Enter your districht: ");
            //passengerDistricht = Console.ReadLine();
            //Console.Write("Enter your city: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Enter your identity number: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();


            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Passenger: " + passengerName + " " + passengerSurname + " " + passengerDistricht + " " + passengerCity + " " + passengerAge, " " + passengerIdentityNumber) ;
            //passengerIdentityNumber = Console.ReadLine();


            #endregion

            #region int keybord input

            //ABC12D
            //int shoePrice, computerPrice, phonePrice, tvPrice;
            //shoePrice = 150;
            //computerPrice = 2500;
            //phonePrice = 1500;
            //tvPrice = 5000;

            //int shoeCount, computerCount, phoneCount, tvCount;

            //Console.WriteLine("***** Product List ******");
            //Console.WriteLine();
            //Console.Write("Please enter the number of shoes you have purchased: ");
            //shoeCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the number of computers you have purchased: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the number of phones you have purchased: ");
            //phoneCount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the number of TVs you have purchased: ");
            //tvCount = Convert.ToInt32(Console.ReadLine());

            //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (phonePrice * phoneCount) + (tvPrice * tvCount);
            //Console.WriteLine();

            //Console.WriteLine("Total Price: " + totalPrice + " CH");


            #endregion

            #region double keybord input
            //double exam1, exam2, exam3, result;
            //Console.Write("Enter the first exam result: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the second exam result: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the third exam result: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Result: " + result);



            #endregion

            #region char keybord input
            
            char gender;
            Console.Write("Enter your Gender: ");
            gender = char.Parse(Console.ReadLine());    
            Console.Write(gender);




            #endregion
            Console.Read();
        }
    }
}
