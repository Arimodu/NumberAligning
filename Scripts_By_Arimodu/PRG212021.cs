using System;
using System.Collections.Generic;
using System.Text;

namespace Scripts_By_Arimodu
{
    class PRG212021
    {
        public static void MainFc() 
        {
            Console.WriteLine("zadej cislo 1:"); //napisu na konzoli to co je v uvozovkach
            string vstup = Console.ReadLine(); //prectu z konzole co tam nekdo napsal a ulozim si to do promene typu string jmenem vstup
            int num = Int32.Parse(vstup); //prevedu promenou typu string na promenou typu int ktera se jmenuje num (jako "number")
            Console.WriteLine("Napsane cislo bylo: " + num); //vypisu promenou num
            Console.WriteLine("Napsane cislo bylo: {0}", num);

            //------------------------------------------------------------------------------------------//
            
            int num1 = 0;
            int num2 = 0;

            bool isNumeric;
            do
            {
                Console.WriteLine("enter the first number:");
                isNumeric = int.TryParse(Console.ReadLine(), out int numN);
                if (isNumeric)
                {
                    num1 = numN;
                }
            } while (!isNumeric);
            do
            {
                Console.WriteLine("enter the second number:");
                isNumeric = int.TryParse(Console.ReadLine(), out int numN);
                if (isNumeric)
                {
                    num2 = numN;
                }
            } while (!isNumeric);

            int soucet = num1 + num2;
            int soucin = num1 * num2;
            int rozdil = 0;
            int podil = 0;
            try
            {
                rozdil = num1 - num2;
                podil = num1 / num2;
            }
            catch (Exception)
            {
                Console.WriteLine("its uncomputable!!!!!!");
                throw;
            }


            Console.WriteLine("Soucet cisel je: {0}\nRozdil cisel je: {1}\nSoucin cisel je: {2}\nPodil cisel je: {3}", soucet, rozdil, soucin, podil);
        }
    }
}
