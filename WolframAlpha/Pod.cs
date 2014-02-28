using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Pod
    {
        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlAttribute("scanner")]
        public string Scanner { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("position")]
        public int Position { get; set; }

        [XmlAttribute("error")]
        public bool Error { get; set; }

        [XmlAttribute("primary")]
        public bool Primary { get; set; }

        [XmlElement("subpod")]
        public List<SubPod> SubPods { get; set; }

        [XmlElement("states")]
        public PodStates States { get; set; }

        [XmlArray("sounds"), XmlArrayItem("sound")]
        public List<Sound> Sounds { get; set; }

        [XmlArray("infos"), XmlArrayItem("info")]
        public List<Info> Infos { get; set; }
    }
}