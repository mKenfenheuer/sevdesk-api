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
  public class ModelSubscriptionType {
    /// <summary>
    /// date the subscription type was created
    /// </summary>
    /// <value>date the subscription type was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the subscription type was last updated
    /// </summary>
    /// <value>date the subscription type was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// name of the subscription type
    /// </summary>
    /// <value>name of the subscription type</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// code of the subscription plan
    /// </summary>
    /// <value>code of the subscription plan</value>
    [DataMember(Name="planCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planCode")]
    public string PlanCode { get; set; }

    /// <summary>
    /// duration of the subscription plan in months
    /// </summary>
    /// <value>duration of the subscription plan in months</value>
    [DataMember(Name="planDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planDuration")]
    public string PlanDuration { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="externalProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalProductId")]
    public string ExternalProductId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="externalProductIdSandbox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalProductIdSandbox")]
    public string ExternalProductIdSandbox { get; set; }

    /// <summary>
    /// net sum payable for the subscription type
    /// </summary>
    /// <value>net sum payable for the subscription type</value>
    [DataMember(Name="sumNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNet")]
    public float? SumNet { get; set; }

    /// <summary>
    /// vat sum payable for the subscription type
    /// </summary>
    /// <value>vat sum payable for the subscription type</value>
    [DataMember(Name="sumVat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumVat")]
    public float? SumVat { get; set; }

    /// <summary>
    /// gross sum payable for the subscription type
    /// </summary>
    /// <value>gross sum payable for the subscription type</value>
    [DataMember(Name="sumGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGross")]
    public float? SumGross { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="externalProductIdGbp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalProductIdGbp")]
    public string ExternalProductIdGbp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumNetGbp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNetGbp")]
    public float? SumNetGbp { get; set; }

    /// <summary>
    /// translation code for the subscription type
    /// </summary>
    /// <value>translation code for the subscription type</value>
    [DataMember(Name="translationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translationCode")]
    public string TranslationCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSubscriptionType {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PlanCode: ").Append(PlanCode).Append("\n");
      sb.Append("  PlanDuration: ").Append(PlanDuration).Append("\n");
      sb.Append("  ExternalProductId: ").Append(ExternalProductId).Append("\n");
      sb.Append("  ExternalProductIdSandbox: ").Append(ExternalProductIdSandbox).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumVat: ").Append(SumVat).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  ExternalProductIdGbp: ").Append(ExternalProductIdGbp).Append("\n");
      sb.Append("  SumNetGbp: ").Append(SumNetGbp).Append("\n");
      sb.Append("  TranslationCode: ").Append(TranslationCode).Append("\n");
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
