using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fab.Lib.Pars
{
    public class Block
    {
        //Attribute

        [XmlAttribute(AttributeName ="guid")]
        public string Guid { get; set; }

        [XmlAttribute(AttributeName = "block_status")]
        public bool BlockStatus { get; set; }

        [XmlAttribute(AttributeName = "block_type")]
        public string BlockType { get; set; }

        //Element

        [XmlElement("chat_name")]
        public string ChatName { get; set; }

        [XmlElement("tecnical_promt")]
        public string TecnicalPromt { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("inputs")]
        public Inputs Inputs { get; set; }

        [XmlElement("outputs")]
        public Outputs Outputs { get; set; }
    }
}
