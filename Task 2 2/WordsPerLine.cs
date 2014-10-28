using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordsPerLine
    {
        public int WordsPerLinePole { get; set; }

        public WordsPerLine(int x)
        {
            this.WordsPerLinePole = x;
        }

        public void Increment()
        {
            this.WordsPerLinePole++;
        }
    }
}
