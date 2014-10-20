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
            TextAnalyzer analysisOfExample = new TextAnalyzer();
            WordList resultOfAnalysis = analysisOfExample.Analyzing(example);
            resultOfAnalysis.Print();
            
            

            Console.ReadKey();
        }
    }
}
