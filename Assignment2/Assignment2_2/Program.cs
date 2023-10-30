using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            TextAnalyzer text = new TextAnalyzer();
            text.InitializeText(out s);
            Console.WriteLine("Initialize text: " + text.GetText() + "\n");
            Console.WriteLine("Content of the collection: ");
            SortedList<char, int> list = text.Collection();
            foreach (var li in list)
                Console.WriteLine("key: " + li.Key+  ", value: " + li.Value);
            Console.ReadLine();
        }
    }
}
