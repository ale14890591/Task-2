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

        private List<WordListItem> list;

        public WordList()
        {
            this.list = new List<WordListItem>();
        }

        public void AddWord(string word)
        {
            this.list.Add(new WordListItem(word));
        }

        public void WordOccurenceIncrement(int index)
        {
            this.list[index].Count++;
        }

        public void WordOccurencePages(int index, int page)
        {
            this.list[index].Pages.Add(page);
        }
    }
}
