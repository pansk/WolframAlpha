using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Source
    {
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("text")]
        public string Text { get; set; }
    }
}
