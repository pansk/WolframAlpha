using System.Xml.Serialization;

namespace WolframAlpha
{
    public class AssumptionValue
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("desc")]
        public string Description { get; set; }

        [XmlAttribute("input")]
        public string Input { get; set; }
    }
}
