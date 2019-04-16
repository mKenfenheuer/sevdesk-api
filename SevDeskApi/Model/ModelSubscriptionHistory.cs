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
  public class ModelSubscriptionHistory {
    /// <summary>
    /// End date of subscription in subscription history
    /// </summary>
    /// <value>End date of subscription in subscription history</value>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Status of the subscription you currently have
    /// </summary>
    /// <value>Status of the subscription you currently have</value>
    [DataMember(Name="currentSubscriptionCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSubscriptionCode")]
    public string CurrentSubscriptionCode { get; set; }

    /// <summary>
    /// Duration of your current subscription
    /// </summary>
    /// <value>Duration of your current subscription</value>
    [DataMember(Name="currentSubscriptionDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSubscriptionDuration")]
    public string CurrentSubscriptionDuration { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSubscriptionHistory {\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  CurrentSubscriptionCode: ").Append(CurrentSubscriptionCode).Append("\n");
      sb.Append("  CurrentSubscriptionDuration: ").Append(CurrentSubscriptionDuration).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
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
