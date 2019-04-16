using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ModelVatReport {
    /// <summary>
    /// date the vat report was created
    /// </summary>
    /// <value>date the vat report was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the vat report was last updated
    /// </summary>
    /// <value>date the vat report was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// StaticCountry of the vat report
    /// </summary>
    /// <value>StaticCountry of the vat report</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public ModelStaticCountry Country { get; set; }

    /// <summary>
    /// date of the vat report
    /// </summary>
    /// <value>date of the vat report</value>
    [DataMember(Name="reportDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportDate")]
    public DateTime? ReportDate { get; set; }

    /// <summary>
    /// year which is reported
    /// </summary>
    /// <value>year which is reported</value>
    [DataMember(Name="reportingYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportingYear")]
    public string ReportingYear { get; set; }

    /// <summary>
    /// period which is reported
    /// </summary>
    /// <value>period which is reported</value>
    [DataMember(Name="reportingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportingPeriod")]
    public string ReportingPeriod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reportingPeriodCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportingPeriodCode")]
    public string ReportingPeriodCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reportingValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportingValues")]
    public string ReportingValues { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="testCase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "testCase")]
    public bool? TestCase { get; set; }

    /// <summary>
    /// define if you want to report the main income method or the profit and loss
    /// </summary>
    /// <value>define if you want to report the main income method or the profit and loss</value>
    [DataMember(Name="actualTaxation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actualTaxation")]
    public bool? ActualTaxation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="corrected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corrected")]
    public bool? Corrected { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="resultFinanceAuthority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultFinanceAuthority")]
    public string ResultFinanceAuthority { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="financeAuthorityTicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financeAuthorityTicketNumber")]
    public string FinanceAuthorityTicketNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVatReport {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  ReportDate: ").Append(ReportDate).Append("\n");
      sb.Append("  ReportingYear: ").Append(ReportingYear).Append("\n");
      sb.Append("  ReportingPeriod: ").Append(ReportingPeriod).Append("\n");
      sb.Append("  ReportingPeriodCode: ").Append(ReportingPeriodCode).Append("\n");
      sb.Append("  ReportingValues: ").Append(ReportingValues).Append("\n");
      sb.Append("  TestCase: ").Append(TestCase).Append("\n");
      sb.Append("  ActualTaxation: ").Append(ActualTaxation).Append("\n");
      sb.Append("  Corrected: ").Append(Corrected).Append("\n");
      sb.Append("  ResultFinanceAuthority: ").Append(ResultFinanceAuthority).Append("\n");
      sb.Append("  FinanceAuthorityTicketNumber: ").Append(FinanceAuthorityTicketNumber).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
