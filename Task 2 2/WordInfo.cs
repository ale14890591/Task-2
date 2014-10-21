using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordInfo
    {
        private Dictionary<int, Dictionary<int, int>> occurencies;

        public Dictionary<int, Dictionary<int, int>> Occurencies
        {
            get { return occurencies; }
        }

        public WordInfo()
        {
            occurencies = new Dictionary<int, Dictionary<int, int>>();
        }

        public void Occure(int page, int line)
        {
            if (!occurencies.ContainsKey(page))
                occurencies.Add(page, new Dictionary<int, int>());

            if (!occurencies[page].ContainsKey(line))
                occurencies[page].Add(line, 0);

            occurencies[page][line]++;
        }
    }
}
