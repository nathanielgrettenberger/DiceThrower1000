using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            diceThrow("30d5");
            Console.ReadKey();
        }
        static void diceThrow(string diceString)
        {
            string[] myArray = diceString.Split('d');
            string diceRolls = myArray[1];
            string diceSides = myArray[0];
            int diceRolls2 = diceRolls.Parse();
            int diceSides2 = diceSides.Parse();
            Random randomNumberGenerator = new Random();
            Console.WriteLine("throwing" + diceRolls2);
            Console.Write("results" + );

            for (int i = 0; i <= diceRolls2; i++)
            {
                Console.WriteLine(randomNumberGenerator.Next(1, diceSides2) + " ");
            }
        }
    }
}



        
        

            
        

        

			 
			




        

    

