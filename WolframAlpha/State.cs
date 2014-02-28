using System.Xml.Serialization;

namespace WolframAlpha
{
    public class State
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("input")]
        public string Input { get; set; }
    }
}