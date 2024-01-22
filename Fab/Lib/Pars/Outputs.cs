using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    public class Outputs
    {
        [XmlElement("output")]
        public List<Output> OutputList { get; set; }
    }
}
