using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Warning
    {
        [XmlAttribute("text")]
        public string Text { get; set; }
    }
}