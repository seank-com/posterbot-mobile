using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Posterbot.Core.Models;

namespace Posterbot.Core.Services
{
    public class DataService : IDataService
    {
        private readonly HttpClient _httpClient;

        public DataService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<PosterTheme>> GetPosterThemesAsync()
        {
            string json = await _httpClient.GetStringAsync(
            "https://seankfn.azurewebsites.net/api/GetExperiments2");
            //"https://seankfn.azurewebsites.net/api/GetPosterThemes");

            List<PosterTheme> result = new List<PosterTheme>();

            JToken t = JToken.Parse(json);
            if (t.Type == JTokenType.Array)
            {
                foreach (JObject item in t.Values<JObject>())
                {
                    result.Add(PosterTheme.FromJObject(item));
                }
            }
            return result;
        }
    }
}
