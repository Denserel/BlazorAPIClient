using BlazorAPIClient.Dtos;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorAPIClient.DataServices
{
    public class GraphQLSpaceXDataService : ISpaceXDataService
    {
        private readonly HttpClient _httpClient;

        public GraphQLSpaceXDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LaunchDto[]> GetAllLanches()
        {
            var queryObject = new
            {
                query = @"{launches {id is_tentative mission_name launch_date_local }}",
                variables = new
                {

                }
            };

            var launchQuery = new StringContent(
                JsonSerializer.Serialize(queryObject),
                Encoding.UTF8,
                "application/json");
            
            var response = await _httpClient.PostAsync("/graphql/", launchQuery);

            response.EnsureSuccessStatusCode();
            
            using var responsSteam = await response.Content.ReadAsStreamAsync();
            var responseResult = await JsonSerializer.DeserializeAsync<GqlData>(responsSteam);

            return responseResult.Data.Launches;
        }
    }
}
