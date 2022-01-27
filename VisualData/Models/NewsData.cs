using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VisualData.Models
{
  public class NewsData
  {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }
    public class Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }



    public static List<NewsData> GetNewsDatas(string ApiNews)
    {
      var apiCallTask = ApiHelper2.ApiCall(ApiNews);
      string result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<NewsData> articleList = JsonConvert.DeserializeObject<List<NewsData>>(jsonResponse["articles"].ToString());

      return articleList;
    }
  }
}