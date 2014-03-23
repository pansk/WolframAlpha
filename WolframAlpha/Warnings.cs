using System.Collections.Generic;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Warnings
    {
        [XmlElement("spellcheck")]
        public List<SpellCheckWarning> SpellChecks { get; set; }
    
        [XmlElement("delimiters")]
        public List<DelimitersWarning> Delimiters { get; set; }

        [XmlElement("translation")]
        public List<TranslationWarning> Translations { get; set; }

        [XmlElement("reinterpret")]
        public List<ReinterpretWarning> Reinterpret { get; set; }

        [XmlIgnore]
        public IEnumerable<Warning> All
        {
            get
            {
                foreach (var spellCheckWarning in SpellChecks)
                {
                    yield return spellCheckWarning;
                }
                foreach (var delimitersWarning in Delimiters)
                {
                    yield return delimitersWarning;
                }
                foreach (var translationWarning in Translations)
                {
                    yield return translationWarning;
                }
                foreach (var reinterpretWarning in Reinterpret)
                {
                    yield return reinterpretWarning;
                }
            }
        }
    }
}