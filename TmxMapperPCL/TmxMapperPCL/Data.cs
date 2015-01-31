using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    public class Data
    {
        [XmlAttribute(DataType = "string", AttributeName = "encoding")]
        public string Encoding { get; set; }

        [XmlAttribute(DataType="string", AttributeName="compression")]
        public string Compression { get; set; }

        [XmlElement(ElementName = "tile")]
        public List<DataTile> Tiles { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class DataTile
    {
        [XmlAttribute(DataType="int", AttributeName="gid")]
        public int GID { get; set; }
    }

}
