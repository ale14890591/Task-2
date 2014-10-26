using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class Word : IComparable<Word>
    {
        public string WordPole { get; set; }

        public Word(string word)
        {
            this.WordPole = word;
        }

        public int CompareTo(Word other)
        {
            return String.Compare(this.WordPole, other.WordPole);
        }
    }
}
