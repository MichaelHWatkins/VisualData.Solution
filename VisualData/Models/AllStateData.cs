  using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
namespace VisualData.Models
{
  public class AllStateData
  {
    public string fips { get; set; }
    public string country { get; set; }
    public string state { get; set; }
    public object county { get; set; }
    public string level { get; set; }
    public object lat { get; set; }
    public string locationId { get; set; }
    public object @long { get; set; }
    public int population { get; set; }
    public Metrics metrics { get; set; }
    public RiskLevels riskLevels { get; set; }
    public int cdcTransmissionLevel { get; set; }
    public Actuals actuals { get; set; }
    public Annotations annotations { get; set; }
    public string lastUpdatedDate { get; set; }
    public string url { get; set; }

    public static AllStateData[] GetAllStateDatas(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      string result = apiCallTask.Result;

      var ObjOrderList = new AllStateData[] { };
      ObjOrderList = JsonConvert.DeserializeObject<AllStateData[]>(result);
      return ObjOrderList;

    }

    // public static AllStateData[] GetAllCountryData(string apiKey)
    // {
    //   var apiCallTask = ApiHelper2.ApiCall(apiKey);
    //   string result = apiCallTask.Result;

    //   var ObjOrderList2 = new AllStateData[] { };
    //   ObjOrderList2 = JsonConvert.DeserializeObject<AllStateData[]>(result);
    //   return ObjOrderList2;

    // }
  }

  public class TestPositivityRatioDetails
  {
    public string source { get; set; }
  }

  public class Metrics
  {
    public double? testPositivityRatio { get; set; }
    public TestPositivityRatioDetails testPositivityRatioDetails { get; set; }
    public double? caseDensity { get; set; }
    public double? contactTracerCapacityRatio { get; set; }
    public double? infectionRate { get; set; }
    public double? infectionRateCI90 { get; set; }
    public double? icuCapacityRatio { get; set; }
    public double? vaccinationsInitiatedRatio { get; set; }
    public double? vaccinationsCompletedRatio { get; set; }
    public double? vaccinationsAdditionalDoseRatio { get; set; }
  }

  public class RiskLevels
  {
    public int overall { get; set; }
    public int testPositivityRatio { get; set; }
    public int caseDensity { get; set; }
    public int contactTracerCapacityRatio { get; set; }
    public int infectionRate { get; set; }
    public int icuCapacityRatio { get; set; }
  }

  public class HospitalBeds
  {
    public int? capacity { get; set; }
    public int? currentUsageTotal { get; set; }
    public int? currentUsageCovid { get; set; }
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class IcuBeds
  {
    public int? capacity { get; set; }
    public int? currentUsageTotal { get; set; }
    public int? currentUsageCovid { get; set; }
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class Age
  {
    [JsonProperty("0-19")]
    public int _019 { get; set; }

    [JsonProperty("20-34")]
    public int _2034 { get; set; }

    [JsonProperty("35-44")]
    public int _3544 { get; set; }

    [JsonProperty("45-54")]
    public int _4554 { get; set; }

    [JsonProperty("55-64")]
    public int _5564 { get; set; }

    [JsonProperty("65-74")]
    public int _6574 { get; set; }

    [JsonProperty("75-84")]
    public int _7584 { get; set; }
    public int _85_plus { get; set; }
    public int unknown { get; set; }

    [JsonProperty("12-15")]
    public int _1215 { get; set; }

    [JsonProperty("16-17")]
    public int _1617 { get; set; }

    [JsonProperty("16-19")]
    public int _1619 { get; set; }

    [JsonProperty("18-24")]
    public int _1824 { get; set; }

    [JsonProperty("20-44")]
    public int _2044 { get; set; }

    [JsonProperty("25-29")]
    public int _2529 { get; set; }

    [JsonProperty("25-34")]
    public int _2534 { get; set; }

    [JsonProperty("25-39")]
    public int _2539 { get; set; }

    [JsonProperty("30-39")]
    public int _3039 { get; set; }

    [JsonProperty("40-49")]
    public int _4049 { get; set; }

    [JsonProperty("46-64")]
    public int _4664 { get; set; }

    [JsonProperty("5-11")]
    public int _511 { get; set; }

    [JsonProperty("50-64")]
    public int _5064 { get; set; }
    public int _65_plus { get; set; }

    [JsonProperty("75+")]
    public int _75 { get; set; }

    [JsonProperty("12-14")]
    public int? _1214 { get; set; }

    [JsonProperty("15-24")]
    public int? _1524 { get; set; }

    [JsonProperty("10-14")]
    public int? _1014 { get; set; }

    [JsonProperty("100-104")]
    public int? _100104 { get; set; }
    public int? _105_plus { get; set; }

    [JsonProperty("15-19")]
    public int? _1519 { get; set; }

    [JsonProperty("20-24")]
    public int? _2024 { get; set; }

    [JsonProperty("30-34")]
    public int? _3034 { get; set; }

    [JsonProperty("35-39")]
    public int? _3539 { get; set; }

    [JsonProperty("40-44")]
    public int? _4044 { get; set; }

    [JsonProperty("45-49")]
    public int? _4549 { get; set; }

    [JsonProperty("5-9")]
    public int? _59 { get; set; }

    [JsonProperty("50-54")]
    public int? _5054 { get; set; }

    [JsonProperty("55-59")]
    public int? _5559 { get; set; }

    [JsonProperty("60-64")]
    public int? _6064 { get; set; }

    [JsonProperty("65-69")]
    public int? _6569 { get; set; }

    [JsonProperty("70-74")]
    public int? _7074 { get; set; }

    [JsonProperty("75-79")]
    public int? _7579 { get; set; }

    [JsonProperty("80-84")]
    public int? _8084 { get; set; }

    [JsonProperty("85-89")]
    public int? _8589 { get; set; }

    [JsonProperty("90-94")]
    public int? _9094 { get; set; }

    [JsonProperty("95-99")]
    public int? _9599 { get; set; }

    [JsonProperty("12-17")]
    public int? _1217 { get; set; }
  }

  public class Race
  {
    public int ai_an { get; set; }
    public int asian { get; set; }
    public int black { get; set; }
    public int multiple { get; set; }
    public int other { get; set; }
    public int pacific_islander { get; set; }
    public int unknown { get; set; }
    public int white { get; set; }
    public int asian_or_pacific_islander { get; set; }
    public int? multiple_other { get; set; }
    public int? native_american { get; set; }
  }

  public class Ethnicity
  {
    public int hispanic { get; set; }

    [JsonProperty("non-hispanic")]
    public int NonHispanic { get; set; }
    public int unknown { get; set; }
  }

  public class Sex
  {
    public int female { get; set; }
    public int male { get; set; }
    public int other { get; set; }
    public int unknown { get; set; }
  }

  public class VaccinesAdministeredDemographics
  {
    public Age age { get; set; }
    public Race race { get; set; }
    public Ethnicity ethnicity { get; set; }
    public Sex sex { get; set; }
  }

  public class VaccinationsInitiatedDemographics
  {
    public Age age { get; set; }
    public Race race { get; set; }
    public Ethnicity ethnicity { get; set; }
    public Sex sex { get; set; }
  }

  public class Actuals
  {
    public int? cases { get; set; }
    public int deaths { get; set; }
    public int? positiveTests { get; set; }
    public int? negativeTests { get; set; }
    public int contactTracers { get; set; }
    public HospitalBeds hospitalBeds { get; set; }
    public IcuBeds icuBeds { get; set; }
    public int? newCases { get; set; }
    public int newDeaths { get; set; }
    public int? vaccinesDistributed { get; set; }
    public int? vaccinationsInitiated { get; set; }
    public int? vaccinationsCompleted { get; set; }
    public int? vaccinationsAdditionalDose { get; set; }  
    public int? vaccinesAdministered { get; set; }
    public VaccinesAdministeredDemographics vaccinesAdministeredDemographics { get; set; }
    public VaccinationsInitiatedDemographics vaccinationsInitiatedDemographics { get; set; }
  }

  public class Source
  {
    public string type { get; set; }
    public string url { get; set; }
    public string name { get; set; }
  }

  public class Anomaly
  {
    public string date { get; set; }
    public string type { get; set; }
    public double original_observation { get; set; }
  }

  public class Cases
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class Deaths
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class PositiveTests
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class NegativeTests
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class ContactTracers
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class NewCases
  {
    public List<object> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class NewDeaths
  {
    public List<object> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class VaccinesDistributed
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class VaccinationsInitiated
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class VaccinationsCompleted
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class VaccinationsAdditionalDose
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class VaccinesAdministered
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class TestPositivityRatio
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class CaseDensity
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class ContactTracerCapacityRatio
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class InfectionRate
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class InfectionRateCI90
  {
    public List<Source> sources { get; set; }
    public List<Anomaly> anomalies { get; set; }
  }

  public class IcuCapacityRatio
  {
    public List<Source> sources { get; set; }
    public List<object> anomalies { get; set; }
  }

  public class Annotations
  {
    public Cases cases { get; set; }
    public Deaths deaths { get; set; }
    public PositiveTests positiveTests { get; set; }
    public NegativeTests negativeTests { get; set; }
    public ContactTracers contactTracers { get; set; }
    public HospitalBeds hospitalBeds { get; set; }
    public IcuBeds icuBeds { get; set; }
    public NewCases newCases { get; set; }
    public NewDeaths newDeaths { get; set; }
    public VaccinesDistributed vaccinesDistributed { get; set; }
    public VaccinationsInitiated vaccinationsInitiated { get; set; }
    public VaccinationsCompleted vaccinationsCompleted { get; set; }
    public VaccinationsAdditionalDose vaccinationsAdditionalDose { get; set; }
    public VaccinesAdministered vaccinesAdministered { get; set; }
    public TestPositivityRatio testPositivityRatio { get; set; }
    public CaseDensity caseDensity { get; set; }
    public ContactTracerCapacityRatio contactTracerCapacityRatio { get; set; }
    public InfectionRate infectionRate { get; set; }
    public InfectionRateCI90 infectionRateCI90 { get; set; }
    public IcuCapacityRatio icuCapacityRatio { get; set; }
    public object vaccinationsInitiatedRatio { get; set; }
    public object vaccinationsCompletedRatio { get; set; }
    public object vaccinationsAdditionalDoseRatio { get; set; }
  }
}