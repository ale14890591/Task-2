using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordInfo
    {
        //key - page, value - dictionary, where key - line, value - words per line
        private Dictionary<PageNumber, Dictionary<LineNumber, WordsPerLine>> occurencies;

        public Dictionary<PageNumber, Dictionary<LineNumber, WordsPerLine>> Occurencies
        {
            get { return occurencies; }
        }

        public WordInfo()
        {
            occurencies = new Dictionary<PageNumber, Dictionary<LineNumber, WordsPerLine>>();
        }

        public void Occure(PageNumber page, LineNumber line)
        {
            if (!occurencies.ContainsKey(page))
                occurencies.Add(page, new Dictionary<LineNumber, WordsPerLine>());

            if (!occurencies[page].ContainsKey(line))
                occurencies[page].Add(line, new WordsPerLine(0));

            occurencies[page][line].Increment();
        }
    }
}
