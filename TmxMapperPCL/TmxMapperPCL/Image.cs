using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    // <image width="128" height="128" source="TilesPack/7.png"/>
    public class Image
    {
        // width
        [XmlAttribute(DataType="int", AttributeName="width")]
        public int Width { get; set; }

        // source
        [XmlAttribute(DataType="string", AttributeName="source")]
        public string Source { get; set; }
        
        // height
        [XmlAttribute(DataType="int", AttributeName="height")]
        public int Height { get; set; }

        // format - optional
        [XmlAttribute(DataType="string", AttributeName="format")]
        public string Format { get; set; }

        // trans - optional
        [XmlAttribute(DataType="string", AttributeName="trans")]
        public string Trans { get; set; }

        // TODO:
        // Can contain: data (since 0.9.0)
    }
}
