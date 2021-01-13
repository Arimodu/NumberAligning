using System;

namespace NumberAligning
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            int mode;
            do
            {
                mode = ModeChoice();
            } while (mode == 0);

            Launcher(mode);
        }

        private static void Launcher(int mode)
        {
            switch (mode)
            {
                case 1:
                    Aligners.CommonStartRandom.Start(mode);
                    break;
                case 2:
                    Aligners.CommonStartRandom.Start(mode);
                    break;
                default:
                    Console.WriteLine("A fatal error accured while selecting mode, launcher cannot start. Please try again.");
                    break;
            }
        }


        private static int ModeChoice()
        {
            Console.WriteLine("Choose mode:");
            Console.WriteLine("1: Align random numbers from highest to lowest");
            Console.WriteLine("2: Align random numbers from lowest to highest");
            char userChoice = Console.ReadKey(true).KeyChar;
            switch (userChoice)
            {
                case '1':
                    ModeChosenMessage(userChoice);
                    return 1;
                case '2':
                    ModeChosenMessage(userChoice);
                    return 2;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Press the corresponding number to choose mode");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue to mode select . . .");
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
            }
        }

        private static void ModeChosenMessage(char mode)
        {
            Console.WriteLine();
            Console.WriteLine("Chosen mode: {0}", mode);
            Console.WriteLine("Press any key to start . . .");
            Console.ReadKey();
            return;
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Number Aligner 1.8");
            Console.WriteLine("Made by Arimodu");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
