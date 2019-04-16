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
  public class ModelAccountingSystemNumber {
    /// <summary>
    /// date the accounting system number was created
    /// </summary>
    /// <value>date the accounting system number was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the accounting system number was last updated
    /// </summary>
    /// <value>date the accounting system number was last updated</value>
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
    /// accounting system number
    /// </summary>
    /// <value>accounting system number</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="numberDepreciation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberDepreciation")]
    public int? NumberDepreciation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingType")]
    public ModelAccountingType AccountingType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingSystem")]
    public ModelAccountingSystem AccountingSystem { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="bookingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingType")]
    public string BookingType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAccountingSystemNumber {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  NumberDepreciation: ").Append(NumberDepreciation).Append("\n");
      sb.Append("  AccountingType: ").Append(AccountingType).Append("\n");
      sb.Append("  AccountingSystem: ").Append(AccountingSystem).Append("\n");
      sb.Append("  BookingType: ").Append(BookingType).Append("\n");
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
