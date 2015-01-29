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
        // id
        [XmlAttribute(DataType="string", AttributeName="id")]      
        public string TileID { get; set; }
       
        // terrain
        [XmlElement(ElementName = "terrain")]
        public Terrain Terrain { get; set; }

        // probability
        [XmlAttribute(DataType="string", AttributeName="probability")]
        public string Probability { get; set; }

        // image
        [XmlElement(ElementName = "image")]
        public Image Image { get; set; }

        // ObjectGroup
        [XmlElement(ElementName = "objectgroup")]
        public List<ObjectGroup> ObjectGroups { get; set; }     

        // properties
        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }                       
    }
}
