using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SkyArticle.Steps
{
    public class ArticleSteps
    {
        string url = "";
        [HttpGet]
        public async Task LoadArticle(int articleUrl)
        {


            if (articleUrl > 0)
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/{articleUrl}";
            }
            else
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/";
            }

            using HttpResponseMessage response = await ApiHelper.SkyCommonStep.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                response.StatusCode.Equals(200);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        [HttpPost]
        public async Task InvalidArticleRequest(int articleUrl)
        {

            if (articleUrl > 0)
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/{articleUrl}";
            }
            else
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/";
            }

            using HttpResponseMessage response = await ApiHelper.SkyCommonStep.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                response.StatusCode.Equals(404);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        [HttpPut]
        public async Task InvalidPutArticleRequest(int articleUrl)
        {

            if (articleUrl > 0)
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/{articleUrl}";
            }
            else
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/";
            }

            using HttpResponseMessage response = await ApiHelper.SkyCommonStep.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                response.StatusCode.Equals(404);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        [HttpDelete]
        public async Task InvalidDeleteArticleRequest(int articleUrl)
        {

            if (articleUrl > 0)
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/{articleUrl}";
            }
            else
            {
                url = $"https://5f99522350d84900163b8737.mockapi.io/tech-test/articles/";
            }

            using HttpResponseMessage response = await ApiHelper.SkyCommonStep.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                response.StatusCode.Equals(404);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}


