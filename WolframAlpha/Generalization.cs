using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Generalization
    {
        [XmlAttribute("topic")]
        public string Topic { get; set; }

        [XmlAttribute("desc")]
        public string Description { get; set; }

        [XmlAttribute("url")]
        public string Url { get; set; }
    }
}