using System.Xml.Serialization;

namespace WolframAlpha
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Response
    {
        [XmlElement("queryresult")]
        public QueryResult QueryResult { get; set; }   
    }
}