using System;

namespace Scripts_By_Arimodu
{
    class ChooseLargestFrom3
    {
        public static void CLF3()
        {
            Console.WriteLine("Enter 3 numbers");
            bool fIsNumeric = int.TryParse(Console.ReadLine(), out int fnum);
            bool sIsNumeric = int.TryParse(Console.ReadLine(), out int snum);
            bool tIsNumeric = int.TryParse(Console.ReadLine(), out int tnum);

            if (!fIsNumeric || !sIsNumeric || !tIsNumeric) 
            {
                Console.WriteLine("Must be a number, try again");
                ChooseLargestFrom3.CLF3();
            }

            if (fnum > snum && fnum > tnum) System.Console.WriteLine($"Number {fnum} is the largest");
            else if (snum > fnum && snum > tnum) System.Console.WriteLine($"Number {snum} is the largest");
            else if (tnum > fnum && tnum > snum) System.Console.WriteLine($"Number {tnum} is the largest");
            else System.Console.WriteLine("WTF?");
        }
    }
}