using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{   
    public class Tile
    {
        [XmlAttribute(DataType="int", AttributeName="id")]      
        public int ID { get; set; }

        [XmlElement(ElementName = "image")]
        public Image Image { get; set; }

        // TODO: optional - terrain
        // TODO: optional - probability

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Property { get; set; }     
   
        // TODO: objectgroup
    }
}
