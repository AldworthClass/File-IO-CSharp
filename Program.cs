using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<int> numbers = new List<int>();
            int average, sum;
            StreamWriter writer = new StreamWriter("capitals.txt");


            //Simple Reading From a File
            foreach (string line in File.ReadLines(@"test.txt", Encoding.UTF8))
            {
                words.Add(line.ToUpper());
            }
            Console.WriteLine($"{words.Count} words read from file");
            Console.WriteLine();
            Console.WriteLine("Press Enter to write to capitals.txt");

            //Simple writing to a file
            //Loops through list and writes to file
            foreach (string word in words)
                writer.WriteLine(word);

            writer.Close(); //Make sure to close the stream
            Console.WriteLine($"{words.Count} lines written, hit enter to continue.");
            Console.ReadLine();




        }
    }
}
