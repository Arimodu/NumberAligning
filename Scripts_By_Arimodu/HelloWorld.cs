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
        }
    }
}
