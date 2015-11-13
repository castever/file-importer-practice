using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = File.ReadAllText(@"C:\_temp\numbers.txt");
            
            //split the file string into ints
            string[] stringNumbers = fileText.Split(',');
            int[] numbers = new int[10];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                var number = Int32.Parse(stringNumbers[i]);
                numbers[i] = number;
            }

            //sort the numbers
            Array.Sort(numbers);

            //create the new string
            string newText = "";
            int index = 0;
            foreach (int number in numbers)
            {
                newText += number;
                if (index < numbers.Length - 1)
                {
                    newText += ",";
                }
                index++;
            }

            //write the text back to the file
            File.WriteAllText(@"C:\_temp\numbers.txt", newText);
        }
    }
}
