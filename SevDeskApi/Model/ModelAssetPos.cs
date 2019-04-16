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
  public class ModelAssetPos {
    /// <summary>
    /// date the asset position was created
    /// </summary>
    /// <value>date the asset position was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the asset position was last updated
    /// </summary>
    /// <value>date the asset position was last updated</value>
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
    /// asset the asset position belongs to
    /// </summary>
    /// <value>asset the asset position belongs to</value>
    [DataMember(Name="asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asset")]
    public Object Asset { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="depreciationAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "depreciationAmount")]
    public float? DepreciationAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="residualValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "residualValue")]
    public float? ResidualValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public int? Month { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="enshrined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enshrined")]
    public bool? Enshrined { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="correction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correction")]
    public bool? Correction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAssetPos {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  DepreciationAmount: ").Append(DepreciationAmount).Append("\n");
      sb.Append("  ResidualValue: ").Append(ResidualValue).Append("\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Enshrined: ").Append(Enshrined).Append("\n");
      sb.Append("  Correction: ").Append(Correction).Append("\n");
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
