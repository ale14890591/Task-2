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
        private List<List<string>> text;
        private static int linesPerPage = 2;

        public List<List<string>> Text
        {
            get { return text; }
        }

        public static int LinesPerPage
        {
            get { return linesPerPage; }
        }

        public TextWork(List<List<string>> text)
        {
            this.text = text;
        }

        public TextWork(string path)
        {
            text = new List<List<string>>();

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                List<string> page = new List<string>();

                for (int line = 0; line < linesPerPage && !reader.EndOfStream; line++)
                {
                    page.Add(reader.ReadLine());
                }

                text.Add(page);
            } 
            
            reader.Close();
        }
    }
}
