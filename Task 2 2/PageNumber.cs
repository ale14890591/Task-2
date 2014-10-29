using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class PageNumber
    {
        public int Value { get; set; }

        public PageNumber(int x)
        {
            this.Value = x;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
