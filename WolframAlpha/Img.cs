using System.Drawing;
using System.Net;
using System.Xml.Serialization;

namespace WolframAlpha
{
    public class Img
    {
        private Image _image;
        private string _imgSource;

        [XmlAttribute("src")]
        public string Source {
            get 
            {
                return _imgSource;
            }
            set 
            {
                _imgSource = value;
                _image = null;
            }
        }

        public Image Image 
        {
            get
            {
                // TODO: put a mutex guard here
                return _image ??
                       (_image = Image.FromStream(WebRequest.Create(_imgSource).GetResponse().GetResponseStream()));
            } 
        }

        [XmlAttribute("alt")]
        public string Alt { get; set; }
        
        [XmlAttribute("title")]
        public string Title { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }
    }
}