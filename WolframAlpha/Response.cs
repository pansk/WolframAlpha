using System.Xml.Serialization;

namespace WolframAlpha
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    internal class Response
    {
        [XmlElement("queryresult")]
        public QueryResult QueryResult { get; set; }   
    }
}