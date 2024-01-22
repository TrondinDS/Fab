using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    public class Output
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "defaultValue")]
        public string DefaultValue { get; set; }

        [XmlElement("inputs_GUI")]
        public InputsGUI InputsGUI { get; set; }
    }
}
