using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class Page
    {
        public List<Line> Value { get; set; }
        private static int linesPerPage = 2;

        public static int LinesPerPage
        {
            get { return linesPerPage; }
        }

        public Page()
        {
            this.Value = new List<Line>();
        }
    }
}
