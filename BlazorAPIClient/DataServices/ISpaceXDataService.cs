using BlazorAPIClient.Dtos;
using System.Threading.Tasks;

namespace BlazorAPIClient.DataServices
{
    public interface ISpaceXDataService
    {
        Task<LaunchDto[]> GetAllLanches();
    }
}
