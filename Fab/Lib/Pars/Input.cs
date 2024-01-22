using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    public class Input
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName =  "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "defaultValue")]
        public string DefaultValue { get; set; }

        [XmlElement("outputs_GUI")]
        public OutputsGUI OutputsGUI { get; set; }
    }
}
