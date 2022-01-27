using System.Threading.Tasks;
using RestSharp;

namespace VisualData.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.covidactnow.org/v2");
      RestRequest request = new RestRequest($"states.timeseries.json?apiKey={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}