using System;
using System.IO;

namespace Scripts_By_Arimodu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if running in debug
            bool debug = false;
            foreach (var item in args)
            {
                if (item == "debug" || item == "-debug")
                {
                    Console.WriteLine("Application running in debug.");
                    Console.WriteLine("Log file generated and saved at: " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                    Tools.Debuggers.Logger("\n \n \nScripts by Arimodu. \nRunning in debug. \nSystem time and date: " + DateTime.Now, 0, Scripts_By_Arimodu.Globals.FileWriter);
                    debug = true;
                }
            }
            
            //Display welcome message
            WelcomeMessage();

            //Get mode from user
            int mode;
            do
            {
                mode = ModeChoice();
            } while (mode == 0);

            //Start the launcher
            Launcher(mode, debug);
        }

        private static void Launcher(int mode, bool debug)
        {
            switch (mode)
            {
                case 1:
                    Console.Clear();
                    Aligners.CommonStartRandom.Start(mode, debug);
                    break;
                case 2:
                    Console.Clear();
                    Aligners.CommonStartRandom.Start(mode, debug);
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("A fatal error occured while selecting mode, launcher cannot start. Please try again.");
                    break;
            }
        }


        private static int ModeChoice()
        {
            Console.WriteLine("Choose mode:");
            Console.WriteLine("1: Align random numbers from highest to lowest");
            Console.WriteLine("2: Align random numbers from lowest to highest");
            Console.WriteLine("3: Hello world, and first scripts");
            char userChoice = Console.ReadKey(true).KeyChar;
            switch (userChoice)
            {
                case '1':
                    ModeChosenMessage(userChoice);
                    return 1;
                case '2':
                    ModeChosenMessage(userChoice);
                    return 2;
                case '3':
                    ModeChosenMessage(userChoice);
                    return 3;
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
            Console.WriteLine("Scripts 1.8");
            Console.WriteLine("Made by Arimodu");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
    static class Globals
    {
        public static string LogPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static StreamWriter FileWriter = new StreamWriter(LogPath + @"\log.txt");
    }
}
