using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Block;

namespace Dorm
{
    internal class Dorm
    {
        public string Name { get; set; }
        List<Block.Block> blocks = new List<Block.Block>();
        public List<Block.Block> Blocks { get { return blocks; } set { blocks = value; } }
    }
}
