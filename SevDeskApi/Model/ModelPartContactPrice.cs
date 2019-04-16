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
  public class ModelPartContactPrice {
    /// <summary>
    /// date the part contact price was created
    /// </summary>
    /// <value>date the part contact price was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the part contact price was last updated
    /// </summary>
    /// <value>date the part contact price was last updated</value>
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
    /// contact for which you have a special price
    /// </summary>
    /// <value>contact for which you have a special price</value>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public Object Contact { get; set; }

    /// <summary>
    /// part for which you have a special price
    /// </summary>
    /// <value>part for which you have a special price</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public Object Part { get; set; }

    /// <summary>
    /// type of the part contact price
    /// </summary>
    /// <value>type of the part contact price</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// special net price for contact
    /// </summary>
    /// <value>special net price for contact</value>
    [DataMember(Name="priceNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceNet")]
    public float? PriceNet { get; set; }

    /// <summary>
    /// special gross price for contact
    /// </summary>
    /// <value>special gross price for contact</value>
    [DataMember(Name="priceGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceGross")]
    public float? PriceGross { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPartContactPrice {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  Part: ").Append(Part).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PriceNet: ").Append(PriceNet).Append("\n");
      sb.Append("  PriceGross: ").Append(PriceGross).Append("\n");
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
