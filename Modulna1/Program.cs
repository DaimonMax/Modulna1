using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    delegate string TextOperation(string text);
    internal class Program
    {
        static void Main()
        {
            string inputFilePath = "textPD21.txt";
            string outputFilePath = "resultPD21.txt";

            ProcessFile(inputFilePath, outputFilePath, UpperCase);
            ProcessFile(inputFilePath, outputFilePath, CharCount);
            ProcessFile(inputFilePath, outputFilePath, WordCount);
        }


        static void ProcessFile(string inputFile, string outputFile, TextOperation textOperation)
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string result = textOperation(line);
                    writer.WriteLine(result);
                }
            }
        }

        static string UpperCase(string text)
        {
            return text.ToUpper();
        }

        static string CharCount(string text)
        {
            return $"Chars: {text.Length}";
        }

        static string WordCount(string text)
        {
            string[] words = text.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            return $"Words: {words.Length}";
        }
    }
}
