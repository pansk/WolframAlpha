using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class SubPod
    {
        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlElement("plaintext")]
        public string PlainText { get; set; }

        [XmlElement("img")]
        public List<Img> Images { get; set; }
    }
}