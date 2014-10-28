using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordList
    {
        //key - word, value - information about how much times does this word appear in a certain line on a certain page
        private SortedDictionary<Word, WordInfo> concordance;
        
        //constructor
        public WordList()
        {
            this.concordance = new SortedDictionary<Word, WordInfo>();        
        }
        
        public void Print()
        {
            string startLetter = this.concordance.First<KeyValuePair<Word, WordInfo>>().Key.WordPole.Substring(0,1);
            Console.WriteLine(startLetter.ToUpper());

            foreach (KeyValuePair<Word, WordInfo> i in concordance)
            {
                if (i.Key.WordPole.Substring(0, 1) != startLetter)
                {
                    startLetter = i.Key.WordPole.Substring(0, 1);
                    Console.WriteLine("\n" + startLetter.ToUpper());
                }

                Console.Write("{0} .. {1} times: pages ", i.Key.WordPole, i.Value.Occurencies.Sum<KeyValuePair<PageNumber, Dictionary<LineNumber, WordsPerLine>>>(y => y.Value.Sum<KeyValuePair<LineNumber, WordsPerLine>>(x => x.Value.WordsPerLinePole)));
         
                foreach (PageNumber j in i.Value.Occurencies.Keys)
                {
                    Console.Write(j.PageNumberPole + " ");
                }

                Console.WriteLine();
            }
        }

        public void WordOccurence(Word key, PageNumber page, LineNumber line)
        {
            if (!this.concordance.ContainsKey(key))
            {
                this.concordance.Add(key, new WordInfo());
            }

            this.concordance[key].Occure(page, line);
        }
    }
}
