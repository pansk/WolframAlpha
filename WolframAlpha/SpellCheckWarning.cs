using System.Xml.Serialization;

namespace WolframAlpha
{
    public class SpellCheckWarning : Warning
    {
        [XmlAttribute("word")]
        public string Word { get; set; }

        [XmlAttribute("suggestion")]
        public string Suggestion { get; set; }
    }
}