using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    [XmlRoot("blocks")]
    public class Blocks
    {
        [XmlElement("block")]
        public List<Block> BlockList { get; set; }
    }
}
