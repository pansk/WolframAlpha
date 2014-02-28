using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class PodStates
    {
        [XmlElement("state")]
        public List<State> States { get; set; }
        
        [XmlElement("statelist")]
        public List<StateList> StateLists { get; set; }
    }
}