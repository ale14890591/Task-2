using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordList : IDictionary<string, List<PageLineCount>>
    {
        //key - word, value - list contains (indexes means pages): 
        //in which line word appeared, how many times it appeared in this line
        private Dictionary<string, List<PageLineCount>> concordance;
        



        //constructor
        public WordList()
        {
            this.concordance = new Dictionary<string, List<PageLineCount>>();            
        }





        //public void AddWord(string word)
        //{
        //    this.concordance.Add(new WordListItem(word)); 

        //    WordListItemsComparer comparer = new WordListItemsComparer();
        //    this.concordance.Sort(comparer);
        //}

        //public void WordCountIncrement(string word)
        //{
        //    foreach (WordListItem i in concordance)
        //    {
        //        if (i.Word == word)
        //            i.Count++;
        //    }
        //}

        //public void WordOccurenceOnPage(string word, int page)
        //{
        //    foreach (WordListItem i in concordance)
        //    {
        //        if (i.Word == word && !i.Pages.Contains(page))
        //            i.Pages.Add(page);
        //    }
        //}

        //public bool ContainsWord(string word)
        //{
        //    foreach (WordListItem i in concordance)
        //    {
        //        if (i.Word == word)
        //            return true;
        //    }

        //    return false;
        //}

        //public void Print()
        //{
        //    foreach (WordListItem i in concordance)
        //    {
        //        Console.Write("{0} .. {1} times: pages ", i.Word, i.Count);
        //        for (int j = 0; j < i.Pages.Count; j++)
        //        {
        //            Console.Write("{0} ", i.Pages[j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}






        public void Add(string key, List<PageLineCount> value)
        {
            this.concordance.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return this.concordance.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(string key)
        {
            return this.concordance.Remove(key);
        }

        public bool TryGetValue(string key, out List<PageLineCount> value)
        {
            throw new NotImplementedException();
        }

        public ICollection<List<PageLineCount>> Values
        {
            get { throw new NotImplementedException(); }
        }

        public List<PageLineCount> this[string key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<string, List<PageLineCount>> item)
        {
            this.concordance.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.concordance.Clear();
        }

        public bool Contains(KeyValuePair<string, List<PageLineCount>> item)
        {
            return this.concordance.ContainsKey(item.Key) && this.concordance.ContainsValue(item.Value);//linq?
        }

        public void CopyTo(KeyValuePair<string, List<PageLineCount>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return this.concordance.Count; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(KeyValuePair<string, List<PageLineCount>> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, List<PageLineCount>>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
