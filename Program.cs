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
            StreamWriter writer = new StreamWriter("capitals.txt");

            //All text files for reading must be in the same directory as the executable file
            //All text files will be written to the same directory as executable file


            //Simple Reading From a File
            if (File.Exists(@"test.txt"))
            {
                foreach (string line in File.ReadLines(@"test.txt", Encoding.UTF8))
                {
                    words.Add(line.ToUpper());
                }
                Console.WriteLine($"{words.Count} words read from file");
                Console.WriteLine("Press Enter to write to capitals.txt");
                Console.ReadLine();

                //Simple writing to a file
                //Loops through list and writes to file
                foreach (string word in words)
                    writer.WriteLine(word);

                writer.Close(); //Make sure to close the stream
                Console.WriteLine($"{words.Count} lines written.  Press Enter to continue.");
            }
            else
            { 
                Console.WriteLine("File not found.  Press Enter to continue.");
            }
            Console.ReadLine();

            //Reading numeric data from file
            Console.WriteLine("Reading numbers from file");

            if (File.Exists(@"test.txt"))
            {
                foreach (string line in File.ReadLines(@"numbers.txt", Encoding.UTF8))
                {
                    numbers.Add(Convert.ToInt32(line.Trim()));
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

                Console.WriteLine("Files processed and written.  Press Enter to close.");
            }
            else
            {
                Console.WriteLine("File not found.  Press Enter to close.");
            }
 
            Console.ReadLine();
        }
    }
}
