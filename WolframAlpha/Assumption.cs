using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Assumption
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("word")]
        public string Word { get; set; }

        [XmlAttribute("template")]
        public string Template { get; set; }

        [XmlElement("value")]
        public List<AssumptionValue> Values { get; set; }
    }
}