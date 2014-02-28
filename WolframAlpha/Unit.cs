using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Unit
    {
        [XmlAttribute("short")]
        public string Short { get; set; }

        [XmlAttribute("long")]
        public string Long { get; set; }

    }
}