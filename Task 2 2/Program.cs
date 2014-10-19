using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWork example = new TextWork(@"C:\Users\000\Desktop\a.txt");
            TextAnalyzer A = new TextAnalyzer();
            example = A.Normalizing(example);
            WordList B = A.Analyzing(example);
            B.Print();
            

            Console.ReadKey();
        }
    }
}
