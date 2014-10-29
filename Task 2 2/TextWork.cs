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
        private List<Page> text;

        public List<Page> Text
        {
            get { return text; }
        }

        
        //constructors
        public TextWork(List<Page> text)
        {
            this.text = text;
        }

        public TextWork(string path)
        {
            text = new List<Page>();

            StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                Page page = new Page();

                for (int line = 0; line < Page.LinesPerPage && !reader.EndOfStream; line++)
                {
                    page.Value.Add(new Line(reader.ReadLine()));
                }

                text.Add(page);
            } 
            
            reader.Close();
        }
    }
}
