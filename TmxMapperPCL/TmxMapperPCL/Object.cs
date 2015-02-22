using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    public class Object
    {
        // name
        [XmlAttribute(DataType = "string", AttributeName = "name")]
        public string Name { get; set; }
                
        // type
        [XmlAttribute(DataType = "string", AttributeName = "type")]
        public string Type { get; set; }

        // x
        [XmlAttribute(DataType = "int", AttributeName = "x")]
        public int X { get; set; }

        // y
        [XmlAttribute(DataType = "int", AttributeName = "y")]
        public int Y { get; set; }

        // width
        [XmlAttribute(DataType = "int", AttributeName = "width")]
        public int Width { get; set; }

        // height
        [XmlAttribute(DataType = "int", AttributeName = "height")]
        public int Height { get; set; }

        // rotation
        [XmlAttribute(DataType = "int", AttributeName = "rotation")]
        public int Rotation { get; set; }
        
        // gid
        [XmlAttribute(DataType = "int", AttributeName = "gid")]
        public int GID { get; set; }

        // visible
        [XmlAttribute(DataType = "boolean", AttributeName = "visible")]
        public bool Visible { get; set; }

        // Can contain: properties, ellipse (since 0.9.0), polygon, polyline, image
        [XmlElement(ElementName = "image")]
        public Image Image { get; set; }

        [XmlElement(ElementName = "ellipse")]
        public Ellipse Ellipse { get; set; }

        // TODO: polygon
        [XmlElement(ElementName = "polygon")]
        public Polygon Polygon { get; set; }

        // TODO: polyline
        [XmlElement(ElementName= "polyline")]
        public Polyline Polyline { get; set; }

        // Properties
        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }  
    }

    public class Ellipse
    {
        // left blanc
    }

    public class Polygon
    {
        [XmlAttribute(DataType="string", AttributeName="points")]
        public string Points { get; set; }
    }

    public class Polyline
    {
        [XmlAttribute(DataType = "string", AttributeName = "points")]
        public string Points { get; set; }
    }
}
