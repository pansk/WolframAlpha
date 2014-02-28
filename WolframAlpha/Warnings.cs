using System.Collections.Generic;
using System.Linq;
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
            get { return SpellChecks.Cast<Warning>().Concat(Delimiters.Cast<Warning>()).Concat(Translations.Cast<Warning>()).Concat(Reinterpret.Cast<Warning>()); }
        }
    }
}