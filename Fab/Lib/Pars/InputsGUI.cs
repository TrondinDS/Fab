using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    public class InputsGUI
    {
        [XmlElement("input_GUI")]
        public List<string> InputGuidList { get; set; }
    }
}
