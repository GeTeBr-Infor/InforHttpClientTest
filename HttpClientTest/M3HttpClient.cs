using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientTest
{
    internal class M3HttpClient
    {
        private static M3HttpClient _instance;   
        
        
        private Dictionary<bool, HttpClient> _clients;

        private M3HttpClient()
        {
            _clients = new Dictionary<bool, HttpClient>();
        }

        public static M3HttpClient Instance()
        {
            if(_instance == null) { _instance = new M3HttpClient(); }
            return _instance;

        }
        public HttpClient GetHttpClient(bool useCookies)
        {
            lock (_instance)
            {
                if (!_clients.ContainsKey(useCookies))
                {
                    HttpClientHandler handler = new HttpClientHandler();
                    handler.UseCookies = useCookies;
                    HttpClient httpClient = new HttpClient(handler);
                    _clients.Add(useCookies, httpClient);
                }

            }
            
            return _clients[useCookies];

        }
    }
}
