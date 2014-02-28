using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Info 
    {
        [XmlElement("img")]
        public Img Image { get; set;}

        [XmlElement("units")]
        public Unit Units { get; set; }

        [XmlElement("link")]
        public List<Link> Links { get; set; }
    }
}