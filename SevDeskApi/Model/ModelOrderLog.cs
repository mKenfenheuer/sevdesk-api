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
  public class ModelOrderLog {
    /// <summary>
    /// date the order log was created
    /// </summary>
    /// <value>date the order log was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the order was last updated
    /// </summary>
    /// <value>date the order was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// date of the order log
    /// </summary>
    /// <value>date of the order log</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// the order to which the order log refers
    /// </summary>
    /// <value>the order to which the order log refers</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public ModelOrder Order { get; set; }

    /// <summary>
    /// the object which was involved in the logged order action (eg. a created invoice)
    /// </summary>
    /// <value>the object which was involved in the logged order action (eg. a created invoice)</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// currency of the logged order
    /// </summary>
    /// <value>currency of the logged order</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// amount of the order position
    /// </summary>
    /// <value>amount of the order position</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// type of the order position amount, can be one from unity or custom
    /// </summary>
    /// <value>type of the order position amount, can be one from unity or custom</value>
    [DataMember(Name="amountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountType")]
    public string AmountType { get; set; }

    /// <summary>
    /// tax rate of the order
    /// </summary>
    /// <value>tax rate of the order</value>
    [DataMember(Name="taxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRate")]
    public int? TaxRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelOrderLog {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  AmountType: ").Append(AmountType).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
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
