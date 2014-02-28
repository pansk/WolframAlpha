using System;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Link 
    {
        [XmlAttribute("url")]
        public string Url { get; set; }
        
        [XmlAttribute("text")]
        public string Text { get; set; }

        [XmlAttribute("title")]
        public string Title { get; set; }
    }
}