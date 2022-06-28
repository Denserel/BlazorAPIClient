using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorAPIClient;
using BlazorAPIClient.Shared;
using System.Text;
using System;
using BlazorAPIClient.Dtos;
using BlazorAPIClient.DataServices;

namespace BlazorAPIClient.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService spaceXDataService { get; set; }

        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync() => launches = await spaceXDataService.GetAllLanches();
    }
}