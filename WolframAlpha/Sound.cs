using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Sound
    {
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}