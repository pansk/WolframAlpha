
namespace WolframAlpha
{
    public class Query
    {
        private const string BaseUrl = "http://blablabla/";
        private string _queryString;
        private string _requestUrl;
        public string ApiKey { get; set; }

        public string QueryString
        {
            get { return _queryString; }
            set
            {
                _queryString = value;
                RefreshUrl();
            }
        }

        private void RefreshUrl()
        {
            RequestUrl = BaseUrl + "?apikey=" + ApiKey;
        }

        public QueryResult Response 
        {
            get; private set; 
        }

        public string RequestUrl
        {
            get { return _requestUrl; }
            private set
            {
                if (value != _requestUrl)
                {
                    _requestUrl = value;
                    Response = null;
                }
            }
        }
    }
}
