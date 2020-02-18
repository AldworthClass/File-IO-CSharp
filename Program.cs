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

            Console.WriteLine("Reading numbers from file");
            foreach (string line in File.ReadLines(@"numbers.txt", Encoding.UTF8))
            {
                numbers.Add(Convert.ToInt32(line));
            }
            numbers.Sort();

            //Write sorted list
            writer = new StreamWriter("sortedNumbers.txt");
            foreach (int number in numbers)
                writer.WriteLine(number + "");
            writer.Close();

            //Write summary
            writer = new StreamWriter("numberSummary.txt");
            
            writer.WriteLine($"The sum is: {numbers.Sum()}");
            writer.WriteLine($"The average is: {numbers.Average()}");
            writer.Close();

            Console.WriteLine("Files processed.  Hit Enter to close");
            Console.ReadLine();
        }
    }
}
