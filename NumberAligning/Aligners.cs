using System;
using System.Collections.Generic;
using System.Text;

namespace Aligners
{
    class CommonStartRandom
    {
        public static void Start(int mode)
        {
            Console.WriteLine("Please enter amount of numbers: ");
            bool isNumeric = int.TryParse(Console.ReadLine(), out int lenght);
            if (!isNumeric)
            {
                Console.WriteLine("Please enter a number");
                Start(mode);
            }
            int[] arr = Tools.Randomizers.RandomIntArrayFiller(lenght);
            if (mode == 1)
            {
                HighToLow.ArraySorter(arr);
            }
            else if (mode == 2)
            {
                LowToHigh.ArraySorter(arr);
            }
            else
            {
                Console.WriteLine("Unknown error (I'm too lazy to find out why)");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
    
    class HighToLow
    {
        public static void ArraySorter(int[] Input)
        {
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

                    foreach (int pos in UsedPos)
                    {
                        if (pos == j && i != 0)
                        {
                            skip = true;
                        }
                    }
                    if (!skip)
                    {
                        if (CurrentLargest < Input[j])
                        {
                            CurrentLargest = Input[j];
                            CurrentLargestPos = j;
                        }
                        else if (CurrentLargest == Input[j])
                        {
                            duplicate[DuplicatePos, 0] = j;
                            duplicate[DuplicatePos, 1] = Input[j];
                            DuplicatePos++;
                        }
                    }
                    else
                    {
                        skip = false;
                    }
                }
                rpt = DuplicatePos;
                Output[i] = CurrentLargest;
                UsedPos[i] = CurrentLargestPos;
                for (int j = 0; j < rpt; j++)
                {
                    if (duplicate[j, 1] == CurrentLargest)
                    {
                        i++;
                        Output[i] = duplicate[j, 1];
                        UsedPos[i] = duplicate[j, 0];
                    }
                }

                for (int k = 0; k < rpt; k++)
                {
                    duplicate[k, 0] = 0;
                    duplicate[k, 1] = 0;
                    DuplicatePos = 0;
                }

                CurrentLargest = 0;
                CurrentLargestPos = 0;
            }

            foreach (int num in Output)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Correct is:");
            Array.Sort(Input);
            Array.Reverse(Input);
            foreach (int num in Input)
            {
                Console.Write(num + ", ");
            }
        }
    }

    class LowToHigh
    {
        public static void ArraySorter(int[] Input)
        {

        }
    }
}
