using System;

namespace FileImporter.Core
{
    public class NumberSorter
    {
        public string Sort(string unsorted)
        {
            //split the file string into ints
            string[] stringNumbers = unsorted.Split(',');
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
            return newText;
        }
    }
}
