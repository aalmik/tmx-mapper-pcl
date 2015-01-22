using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
         
    public class Property
    {
        // name
        [XmlAttribute(DataType = "string", AttributeName = "name")]
        public string Name { get; set; }

        // value
        [XmlAttribute(DataType = "string", AttributeName = "value")]
        public string Value { get; set; }
    }
}
