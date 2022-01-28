using System.Threading.Tasks;
using RestSharp;

namespace VisualData
{
  class ApiHelper2
  {
    public static async Task<string> ApiCall(string ApiNews)
    {
      RestClient client = new RestClient("https://newsapi.org/v2");
      RestRequest request = new RestRequest($"top-headlines?q=covid&language=en&sortBy=publishedAt&apiKey={ApiNews}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}