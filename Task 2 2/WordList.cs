using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class WordList
    {
        //key - word, value - list contains (indexes means pages): 
        //in which line word appeared, how many times it appeared in this line
        private Dictionary<string, WordInfo> concordance;
        

        //constructor
        public WordList()
        {
            this.concordance = new Dictionary<string, WordInfo>();        
        }

        public void Print()
        {
            foreach (KeyValuePair<string, WordInfo> i in concordance)
            {
                Console.Write("{0} .. {1} times: pages ", i.Key, i.Value.Occurencies.Values.Sum(
                
                
                for (int j = 0; j < i.Value.Occurencies.Keys.Count; j++)
                {
                    Console.Write("{0} ", i.Value.Occurencies.);
                }
                Console.WriteLine();
            }
        }

        public void WordOccurence(string key, int page, int line)
        {
            if (!this.concordance.ContainsKey(key))
            {
                this.concordance.Add(key, new WordInfo());
            }

            this.concordance[key].Occure(page, line);
        }






        public void Add(string key, WordInfo value)
        {
            this.concordance.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return this.concordance.ContainsKey(key);
        }

        public ICollection<string> Keys
        {
            get
            {
                return this.concordance.Keys;
            }
        }

        public bool Remove(string key)
        {
            return this.concordance.Remove(key);
        }

        public bool TryGetValue(string key, out WordInfo value)
        {
            if (this.concordance.ContainsKey(key))
            {
                value = this.concordance[key];
                return true;
            }
            else
            {
                value = default(WordInfo);
                return false;
            }
        }

        public ICollection<WordInfo> Values
        {
            get
            {
                return this.concordance.Values;
            }
        }

        public WordInfo this[string key]
        {
            get
            {
                return this.concordance[key];
            }
            set
            {
                this.concordance[key] = value;
            }
        }

        public void Add(KeyValuePair<string, WordInfo> item)
        {
            this.concordance.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.concordance.Clear();
        }

        public bool Contains(KeyValuePair<string, WordInfo> item)
        {
            return this.concordance.ContainsKey(item.Key) && this.concordance.ContainsValue(item.Value);//linq?
        }

        public void CopyTo(KeyValuePair<string, WordInfo>[] array, int arrayIndex)
        {
            throw new NotImplementedException();//??????????????????????????????????????????????????????????????????????
            //if (arrayIndex >= 0 && arrayIndex < this.concordance.Count)
            //{
            //    array = new KeyValuePair<string, List<PageLineCount>>[this.concordance.Count - arrayIndex];

            //    for(int i = 0;i<array.Length
            //}
        }

        public int Count
        {
            get { return this.concordance.Count; }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(KeyValuePair<string, WordInfo> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, WordInfo>> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
