using System;
using System.Text;
using MyApp;
using static System.Text.ASCIIEncoding;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer obj = new FizzBuzzer();
            
            // In this method we give the function two lists that are assumed to be equal length and have index-relationships (ex. 2 => Fizz looking below
            // The return value is a byte array to make the transfer between the method and any other source as faster than a List or other containers. 
            int[] keys = new int[] { 2, 4, 9, 12, 15 };
            string[] values = new string[] { "Fizz", "Buzz", "Jump", "Skip", "Roll" };
            // long a = GC.GetTotalMemory(true);
            byte[] results = obj.processSnapCrackles(5, 300, keys, values);
            // long b = GC.GetTotalMemory(true);
            string value = Encoding.ASCII.GetString(results);
            foreach (string str in value.Split(' '))
            {
                Console.WriteLine(str);
            }
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            Console.ReadLine();

            // Slower Method
            /*List<KeyValuePair<int,string>> testTuplesList = new List<KeyValuePair<int, string>>();
            testTuplesList.Add(new KeyValuePair<int, string>(1, "Snap"));
            testTuplesList.Add(new KeyValuePair<int, string>(2, "Crackle"));
            testTuplesList.Add(new KeyValuePair<int, string>(4, "Pop"));
            testTuplesList.Add(new KeyValuePair<int, string>(6, "Roll"));
            testTuplesList.Add(new KeyValuePair<int, string>(7, "Jump"));*/

        }

    }
}
