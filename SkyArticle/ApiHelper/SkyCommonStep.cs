using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SkyArticle.ApiHelper
{
    public class SkyCommonStep
    {
        public static HttpClient ApiClient { get; set; }

        public  static void Initialize()

        {
            ApiClient = new HttpClient();
          //  ApiClient.BaseAddress = new Uri("https://5f99522350d84900163b8737.mockapi.io/tech-test/articles");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
    }
}
