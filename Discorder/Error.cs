using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder
{
    [System.SerializableAttribute()]
    public class Error
    {
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="msg")]
        public string Message { get; set; }
    }
}
