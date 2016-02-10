using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApp
{
    public class FizzBuzzer
    {
        // Requirements:
        // Print 1 - 100 
        // If % 3 == 0 print Number and Snap
        // If % 5 == 0 print Number and Crackle
        // If % 3 == 0 % 5 == 0 print Number and SnapCrackle
        // Make useable by other programs, whatever they may be.
        // Pass own range
        // Remove Console.WriteLine -- Done
        // Consider Memory -- Done (byte array returned for easy transport)
        // Specify Denominators  -- key/values passed in, the commented out code below takes List<KVP<int,string>>
        // Many Denominators -- This solution is scalable
        // Naming Convention -- Made naming convention a little better
        // Put on GitHuB -- 
        public byte[] processSnapCrackles(int lowerBound, int upperBound, int[] keys, string[] values)
        {
            string str = "";
            // Go through the range
            for (int i = lowerBound; i <= upperBound; i++)
            {
                str += i;
                // After adding the number, cycle through all the keys to populate the "values" onto the string
                for (int j = 0; j < keys.Length; j++)
                {
                    if (i%keys[j] == 0)
                    {
                        str += values[j];
                    }
                }
                str += " ";
            }
            // Encode the string to bytes to transfer lightly/easily
            byte[] results = Encoding.ASCII.GetBytes(str);
            return results;
        }
        //Slower method

        //public byte[] processSnapCrackless(int lowerBound, int upperBound, List<KeyValuePair<int, string>> denomsList)
        //{
        //    string str = "";
        //    int stabalizer = 0;
        //    for (int i = lowerBound; i <= upperBound; i++)
        //    {
        //        str += i + " ";
        //        foreach (KeyValuePair<int, string> kvp in denomsList)
        //        {
        //            if (i % kvp.Key == 0)
        //                str += kvp.Value;
        //        }
        //        str += " ";
        //    }
        //    byte[] results = Encoding.ASCII.GetBytes(str);
        //    return results;
        //}
    }
}
