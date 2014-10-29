using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordsPerLine
    {
        public int Value { get; set; }

        public WordsPerLine(int x)
        {
            this.Value = x;
        }

        public void Increment()
        {
            this.Value++;
        }
    }
}
