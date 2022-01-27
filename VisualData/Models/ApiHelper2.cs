using System.Threading.Tasks;
using RestSharp;

namespace VisualData
{
  class ApiHelper2
  {
    public static async Task<string> ApiCall(string ApiNews)
    {
      RestClient client = new RestClient("https://newsapi.org/v2");
      RestRequest request = new RestRequest($"everything?q=covid&from=2021-12-26&sortBy=publishedAt&apiKey={ApiNews}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}