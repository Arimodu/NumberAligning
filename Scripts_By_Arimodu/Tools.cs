using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tools
{
    class Randomizers
    {
        public static int[] RandomIntArrayFiller(int length)
        {
            int[] arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            return arr;
        }
    }
    class Debuggers
    {
        public static void Logger(string message, int appmode, StreamWriter FileWriter, string parm1 = null, string parm2 = null, string parm3 = null, string parm4 = null)
        {
            //if (debug) Debuggers.Logger(x, Convert.ToString(x), Convert.ToString(x), Convert.ToString(x), Convert.ToString(x));
            bool isNumeric = int.TryParse(message, out int msg);
            if (!isNumeric && message == "line")
            {
                FileWriter.WriteLine("-------------------------------------------------------------------");
                msg = -1;
            }
            else if (!isNumeric && message != "line")
            {
                FileWriter.WriteLine(message);
                msg = -1;
            }
            switch (msg)
            {
                case -1:
                    break;
                case 0:
                    FileWriter.WriteLine("New cycle");
                    break;
                case 1:
                    FileWriter.WriteLine("UsedPos check finished with skip value: *{0}* on pos {1} with value {2}", parm1, parm2, parm3);
                    break;
                case 2:
                    FileWriter.WriteLine("New CurrentLargest found. Previous values: {0}, on pos {1}. ", parm1, parm2);
                    break;
                case 3:
                    FileWriter.WriteLine("Current values: {0}, on pos {1}.", parm1, parm2);
                    break;
                case 4:
                    FileWriter.Write("Duplicate found. ");
                    FileWriter.Write("New Duplicate is: {0}, on pos {1}. ", parm1, parm2);
                    FileWriter.WriteLine("New DuplicatePos: {0}", parm3);
                    break;
                case 5:
                    FileWriter.WriteLine("Search cycle finished. Results: CurrentLargest: {0}, CurrentLargestPos: {1}, DuplicatePos: {2}", parm1, parm2, parm3);
                    FileWriter.WriteLine("");
                    break;
                case 6:
                    FileWriter.WriteLine("-------------------------------------------------------------------");
                    FileWriter.WriteLine("Finished Searching. Results: CurrentLargest: {0}, CurrentLargestPos: {1}, DuplicatePos: {2}", parm1, parm2, parm3);
                    FileWriter.WriteLine("-------------------------------------------------------------------");
                    break;
                case 7:
                    FileWriter.WriteLine("Checking duplicate {0}, on pos {1} with CurrentLargest {2}, on pos {3}", parm1, parm2, parm3, parm4);
                    break;
                case 8:
                    FileWriter.WriteLine("Duplicate {0} is valid. Position {1} and {2} are duplicates.", parm1, parm2, parm3);
                    break;
                case 9:
                    FileWriter.WriteLine("Duplicate not valid. Skipping.");
                    break;
                default:
                    FileWriter.WriteLine("Error");
                    break;
            }
            //FileWriter.Close();
        }
    }
}
