using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public struct GlossaryItem<KeyType, PositionType>
    {
        public KeyType Key { get; set; }
        public int Count { get; set; }
        public IEnumerable<PositionType> Occuriences { get; set; }
    }
}
