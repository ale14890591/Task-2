using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2_2
{
    public class TextWork
    {
        private List<StringBuilder> text;

        public List<StringBuilder> Text
        {
            get { return text; }
        }

        public TextWork(string path)
        {
            text = new List<StringBuilder>();

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                text.Add(new StringBuilder(reader.ReadLine()));
            }
        }
    }
}
