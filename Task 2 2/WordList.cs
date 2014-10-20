using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordList
    {
        private class WordListItem
        {
            public string Word {get;set;}
            public int Count {get;set;}
            public List<int> Pages {get;set;}

            public WordListItem(string word)
            {
                this.Word = word;
                this.Count = 0;
                this.Pages = new List<int>();
            }
        }



        private List<WordListItem> concordance;


        //constructor
        public WordList()
        {
            this.concordance = new List<WordListItem>();
        }




        public void AddWord(string word)
        {
            this.concordance.Add(new WordListItem(word)); 

            WordListItemsComparer comparer = new WordListItemsComparer();
            this.concordance.Sort(comparer);
        }

        public void WordCountIncrement(string word)
        {
            foreach (WordListItem i in concordance)
            {
                if (i.Word == word)
                    i.Count++;
            }
        }

        public void WordOccurenceOnPage(string word, int page)
        {
            foreach (WordListItem i in concordance)
            {
                if (i.Word == word && !i.Pages.Contains(page))
                    i.Pages.Add(page);
            }
        }

        public bool ContainsWord(string word)
        {
            foreach (WordListItem i in concordance)
            {
                if (i.Word == word)
                    return true;
            }

            return false;
        }

        public void Print()
        {
            foreach (WordListItem i in concordance)
            {
                Console.Write("{0} .. {1} times: pages ", i.Word, i.Count);
                for (int j = 0; j < i.Pages.Count; j++)
                {
                    Console.Write("{0} ", i.Pages[j]);
                }
                Console.WriteLine();
            }
        }







        private class WordListItemsComparer : IComparer<WordListItem>
        {
            public int Compare(WordListItem x, WordListItem y)
            {
                return String.Compare(x.Word, y.Word);
            }
        }
    }
}
