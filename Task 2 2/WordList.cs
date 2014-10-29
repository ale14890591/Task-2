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
        
        public void OutputToConsole()
        {
            IEnumerable<GlossaryItem<string, int>> glossary = concordance.Select(x => new GlossaryItem<string, int>()
                {
                    Key = x.Key.Value,
                    Count = x.Value.Occurencies.Sum(a => a.Value.Sum(b => b.Value.Value)),
                    Occuriences = x.Value.Occurencies.Keys.Distinct(new PageNumberComparer()).Select(c => c.Value)
                }).OrderBy(x => x.Key);

            var groupByFirstLetter = from x in glossary
                    group x by x.Key.Substring(0, 1)
                        into p
                        orderby p.Key
                        select p;

            foreach(var i in groupByFirstLetter)
            {
                Console.WriteLine(i.Key.ToUpper());
                
                foreach(var j in i)
                {
                    Console.Write("{0} .. {1} times: pages ", j.Key, j.Count);
                    foreach (var item in j.Occuriences)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        public void OutputToFile(string path)
        {
            using (System.IO.StreamWriter w = new System.IO.StreamWriter(path))
            {
                IEnumerable<GlossaryItem<string, int>> glossary = this.concordance.Select(x => new GlossaryItem<string, int>()
                {
                    Key = x.Key.Value,
                    Count = x.Value.Occurencies.Sum(a => a.Value.Sum(b => b.Value.Value)),
                    Occuriences = x.Value.Occurencies.Keys.Distinct(new PageNumberComparer()).Select(c => c.Value)
                }).OrderBy(x => x.Key);

                var groupByFirstLetter = from x in glossary
                                          group x by x.Key.Substring(0, 1)
                                              into p
                                              orderby p.Key
                                              select p;

                
                foreach (var i in groupByFirstLetter)
                {
                    w.WriteLine(i.Key.ToUpper());

                    foreach (var j in i)
                    {
                        w.Write("{0} .. {1} times: pages ", j.Key, j.Count);

                        foreach (var item in j.Occuriences)
                        {
                            w.Write("{0} ", item);
                        }

                        w.WriteLine();
                    }

                    w.WriteLine();
                }
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
