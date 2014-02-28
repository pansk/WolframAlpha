using System.Xml.Serialization;

namespace WolframAlpha
{
    public class TranslationWarning : Warning
    {
        [XmlAttribute("phrase")]
        public string Phrase { get; set; }

        [XmlAttribute("trans")]
        public string Translation { get; set; }

        [XmlAttribute("lang")]
        public string Language { get; set; }

    }
}