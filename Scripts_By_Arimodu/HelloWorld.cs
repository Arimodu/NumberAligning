using System;
using System.Collections.Generic;
using System.Text;

namespace Scripts_By_Arimodu
{
    class HelloWorld
    {
        public static void HelloWorldMain()
        {
            Console.WriteLine("Hello world\nNext line");
            int numbers = 1;
            string sentence;
            double decimals = 2.01;
            char keystroke;

            Console.WriteLine(numbers);
            Console.WriteLine(decimals);

            sentence = Console.ReadLine();
            Console.WriteLine(sentence);
            keystroke = Console.ReadKey().KeyChar;
            Console.WriteLine(keystroke);

            int number1 = 0;
            int number2 = 0;

            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number1 + number2);







            Console.WriteLine("zadej cislo 1:"); //napisu na konzoli to co je v uvozovkach
            string vstup = Console.ReadLine(); //prectu z konzole co tam nekdo napsal a ulozim si to do promene typu string jmenem vstup
            int num = Int32.Parse(vstup); //prevedu promenou typu string na promenou typu int ktera se jmenuje num (jako "number")
            Console.WriteLine(num); //vypisu promenou num







            Console.WriteLine("zadej cislo 2:"); //napisu na konzoli to co je v uvozovkach
            int num2 = Int32.Parse(Console.ReadLine()); //prectu z konzole co tam nekdo napsal a prevedu to ze stringu na int jmenem num2
            Console.WriteLine(num2); //vypisu promenou num2


        }
    }
}
