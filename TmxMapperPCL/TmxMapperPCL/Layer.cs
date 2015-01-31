using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    public class Layer
    {
        // name
        [XmlAttribute(DataType="string", AttributeName="name")]
        public string Name { get; set; }
        
        // x
        [XmlAttribute(DataType="int", AttributeName="x")]
        public int X { get; set; }
        
        // y
        [XmlAttribute(DataType="int", AttributeName="y")]
        public int Y { get; set; }

        // width
        [XmlAttribute(DataType = "int", AttributeName = "width")]
        public int Width { get; set; }

        // height       
        [XmlAttribute(DataType = "int", AttributeName = "height")]
        public int Height { get; set; }

        // opacity
        [XmlAttribute(DataType = "boolean", AttributeName = "opacity")]
        public bool Opacity { get; set; }

        // visible
        [XmlAttribute(DataType = "boolean", AttributeName = "visible")]
        public bool Visible { get; set; }
       
        // data
        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }

        // properties
        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }    
      
        // Can contain: properties, data
    }
}
