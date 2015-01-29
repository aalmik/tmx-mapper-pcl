using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    public class ObjectGroup
    {
        [XmlAttribute(DataType="string", AttributeName="name")]
        public string Name { get; set; }

        [XmlAttribute(DataType = "string", AttributeName = "color")]
        public string Color { get; set; }

        [XmlAttribute(DataType = "boolean", AttributeName = "opacity")]
        public bool Opacity { get; set; }
        
        [XmlAttribute(DataType = "boolean", AttributeName = "visible")]
        public bool Visible { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }

        [XmlElement(ElementName = "object")]
        public List<Object> Objects { get; set; }     
    }    
}
