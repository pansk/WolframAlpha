using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class ReinterpretWarning : Warning
    {
        [XmlAttribute("new")]
        public string New { get; set; }

        [XmlElement("alternative")]
        public List<string> Alternatives { get; set; }
    }
}