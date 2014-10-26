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
            Func<KeyValuePair<int,int>, int> s = (KeyValuePair<int,int> i) =>{
                return i.Value;
                };
            Func<KeyValuePair<int,Dictionary<int,int>>, int> sel = (KeyValuePair<int, Dictionary<int,int>> i) =>{
                return i.Value.Sum<KeyValuePair<int, int>>(s);
                };
            foreach (KeyValuePair<Word, WordInfo> i in concordance)
            {                
                Console.Write("{0} .. {1} times: pages ", i.Key.WordPole, i.Value.Occurencies.Sum<KeyValuePair<int,Dictionary<int,int>>>(sel));

                foreach (int j in i.Value.Occurencies.Keys)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void WordOccurence(Word key, int page, int line)
        {
            if (!this.concordance.ContainsKey(key))
            {
                this.concordance.Add(key, new WordInfo());
            }

            this.concordance[key].Occure(page, line);
        }
    }
}
