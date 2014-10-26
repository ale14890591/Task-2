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
        //private int linesPerPage = 2;

        public List<Page> TextPole
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
                    page.PagePole.Add(new Line(reader.ReadLine()));
                }

                text.Add(page);
            } 
            
            reader.Close();
        }
    }
}
