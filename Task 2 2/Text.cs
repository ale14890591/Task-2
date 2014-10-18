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
        private List<List<StringBuilder>> text;

        public List<List<StringBuilder>> Text
        {
            get { return text; }
        }

        public TextWork(string path)
        {
            text = new List<List<StringBuilder>>();

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                List<StringBuilder> x = new List<StringBuilder>();

                for (int i = 0; i < 2; i++)
                {
                    x.Add(new StringBuilder(reader.ReadLine()));
                }

                text.Add(x);
            }
        }
    }
}
