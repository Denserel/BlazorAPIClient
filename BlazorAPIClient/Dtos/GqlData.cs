using System.Text.Json.Serialization;

namespace BlazorAPIClient.Dtos
{
    public class GqlData
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("launches")]
        public LaunchDto[] Launches { get; set; }
    }

    /*public class Launch
    {
        public string id { get; set; }
        public bool is_tentative { get; set; }
        public string mission_name { get; set; }
        public DateTime launch_date_local { get; set; }
    }*/

}
