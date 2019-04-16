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
  public class ModelStaticReferralProgram {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="headline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headline")]
    public string Headline { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="rewardAmountLead", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardAmountLead")]
    public float? RewardAmountLead { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="rewardAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardAmount")]
    public float? RewardAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="rewardPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardPercentage")]
    public float? RewardPercentage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="rewardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardType")]
    public string RewardType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="earningAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earningAmount")]
    public float? EarningAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelStaticReferralProgram {\n");
      sb.Append("  Headline: ").Append(Headline).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  RewardAmountLead: ").Append(RewardAmountLead).Append("\n");
      sb.Append("  RewardAmount: ").Append(RewardAmount).Append("\n");
      sb.Append("  RewardPercentage: ").Append(RewardPercentage).Append("\n");
      sb.Append("  RewardType: ").Append(RewardType).Append("\n");
      sb.Append("  EarningAmount: ").Append(EarningAmount).Append("\n");
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
