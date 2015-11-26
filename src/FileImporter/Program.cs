using FileImporter.Core;
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

            var numberSorter = new NumberSorter();
            var newText = numberSorter.Sort(fileText);

            //write the text back to the file
            File.WriteAllText(@"C:\_temp\numbers.txt", newText);
        }
    }
}
