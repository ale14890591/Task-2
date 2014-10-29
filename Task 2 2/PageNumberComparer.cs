using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class PageNumberComparer :IEqualityComparer<PageNumber>
    {
        public bool Equals(PageNumber x, PageNumber y)
        {
            return x.Value == y.Value ? true : false;
        }

        public int GetHashCode(PageNumber obj)
        {
            return obj.Value.GetHashCode();
        }
    }
}
