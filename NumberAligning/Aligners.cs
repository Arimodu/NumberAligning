using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tools;

namespace Aligners
{
    class CommonStartRandom
    {
        public static void Start(int mode, bool debug)
        {
            Console.Write("Please enter amount of numbers: ");

            //Try parsing the entered value as an int. Outputs a boolean and if successful a numeric value.
            bool isNumeric = int.TryParse(Console.ReadLine(), out int lenght);

            //Restart if not numeric
            if (!isNumeric)
            {
                Console.WriteLine("Please enter a number");
                Start(mode, debug);
            }

            //Generate and fill an array with random numebrs using array randomizer in tools.
            int[] arr = Tools.Randomizers.RandomIntArrayFiller(lenght);

            //Choose sorting method according to the mode.
            if (mode == 1)
            {
                ArraySorter.HighToLow(arr, debug);
            }
            else if (mode == 2)
            {
                ArraySorter.LowToHigh(arr, debug);
            }
            else
            {
                //This code theoretically should never run, but it has to be here in case something goes wrong...
                Console.WriteLine("Unknown error (I'm too lazy to find out why)");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
    
    class ArraySorter
    {
        public static void HighToLow(int[] Input, bool debug)
        {
            //Initializing variables
            int[] Output = new int[Input.Length];
            int CurrentLargest = 0;
            int CurrentLargestPos = 0;
            int[] UsedPos = new int[Input.Length];
            bool skip = false;
            int[,] duplicate = new int[Input.Length, 2];
            int DuplicatePos = 0;
            int rpt;


            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = 0; j < Input.Length; j++)
                {
                    if (debug) Debuggers.Logger("0");

                    //Checking if the current position is already used
                    //Note to self, the bug is here, the first position is always skipped for some reason...
                    for (int k = 0; k < i + 1; k++)
                    {
                        if (UsedPos[k] == j)
                        {
                            skip = true;
                        }
                    }
                    
                    if (debug) Debuggers.Logger("1", Convert.ToString(skip), Convert.ToString(j), Convert.ToString(Input[j]));

                    //Skip reading if already used
                    if (!skip)
                    {
                        if (CurrentLargest < Input[j])
                        {
                            if (debug) Debuggers.Logger("2", Convert.ToString(CurrentLargest), Convert.ToString(CurrentLargestPos));
                            CurrentLargest = Input[j];
                            CurrentLargestPos = j;
                            if (debug) Debuggers.Logger("3", Convert.ToString(CurrentLargest), Convert.ToString(CurrentLargestPos)); 
                        }
                        else if (CurrentLargest == Input[j])
                        {
                            duplicate[DuplicatePos, 0] = j;
                            duplicate[DuplicatePos, 1] = Input[j];
                            DuplicatePos++;
                            if (debug) Debuggers.Logger("4", Convert.ToString(duplicate[DuplicatePos-1, 1]), Convert.ToString(duplicate[DuplicatePos-1, 0]), Convert.ToString(DuplicatePos));
                        }
                    }
                    else
                    {
                        skip = false;
                    }
                    if (debug) Debuggers.Logger("5", Convert.ToString(CurrentLargest), Convert.ToString(CurrentLargestPos), Convert.ToString(DuplicatePos));
                }

                //Move values into output
                if (debug) Debuggers.Logger("6", Convert.ToString(CurrentLargest), Convert.ToString(CurrentLargestPos), Convert.ToString(DuplicatePos), Convert.ToString(i));
                rpt = DuplicatePos;
                Output[i] = CurrentLargest;
                UsedPos[i] = CurrentLargestPos;
                for (int j = 0; j < rpt; j++)
                {
                    if (debug) Debuggers.Logger("7", Convert.ToString(duplicate[j, 1]), Convert.ToString(duplicate[j, 0]), Convert.ToString(CurrentLargest), Convert.ToString(CurrentLargestPos));
                    if (duplicate[j, 1] == CurrentLargest)
                    {
                        if (debug) Debuggers.Logger("8", Convert.ToString(duplicate[j, 1]), Convert.ToString(CurrentLargestPos), Convert.ToString(duplicate[j, 0]));
                        i++;
                        Output[i] = duplicate[j, 1];
                        UsedPos[i] = duplicate[j, 0];
                    }
                    else
                    {
                        if (debug) Debuggers.Logger("9");
                    }
                }
                if (debug) Debuggers.Logger("line");
                for (int k = 0; k < rpt; k++)
                {
                    duplicate[k, 0] = 0;
                    duplicate[k, 1] = 0;
                    DuplicatePos = 0;
                }

                CurrentLargest = 0;
                CurrentLargestPos = 0;
                Console.Write("\rCompleted {0}%", (Input.Length/100)*i);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Generated input was: ");
            foreach (var num in Input)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Sorted output is: ");
            foreach (int num in Output)
            {
                Console.Write(num + ", ");
            }

            if (debug)
            {
                Console.WriteLine("\n");
                Console.WriteLine("!!Debug!! \nCorrectly sorted is:");
                Array.Sort(Input);
                Array.Reverse(Input);
                foreach (int num in Input)
                {
                    Console.Write(num + ", ");
                }
            }
        }

        internal static void LowToHigh(int[] Input, bool debug)
        {
            throw new NotImplementedException();
        }
    }
}
