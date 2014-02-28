using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class StateList
    {
        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlElement("state")]
        public List<State> States { get; set; }
    }
}