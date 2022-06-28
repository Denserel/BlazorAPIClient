using System.Threading.Tasks;
using System.Net.Http.Json;
using BlazorAPIClient.Dtos;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;


namespace BlazorAPIClient.Pages
{
    public partial class FetchData
    {
        [Inject]
        private HttpClient Http { get; set; }
        /*[Inject]
        private IConfiguration Configuration { get; set; }*/
        private LaunchDto[] launches;
        protected override async Task OnInitializedAsync()
        {
            //var i = Configuration["api_base_url"];
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("/rest/launches");
        }
        
    }
}