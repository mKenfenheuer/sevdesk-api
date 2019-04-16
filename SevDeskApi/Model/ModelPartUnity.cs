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
  public class ModelPartUnity {
    /// <summary>
    /// date the part unity was created
    /// </summary>
    /// <value>date the part unity was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the part unity was last updated
    /// </summary>
    /// <value>date the part unity was last updated</value>
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
    /// part involved in the part unity
    /// </summary>
    /// <value>part involved in the part unity</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public Object Part { get; set; }

    /// <summary>
    /// price of the part
    /// </summary>
    /// <value>price of the part</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// factor of the part
    /// </summary>
    /// <value>factor of the part</value>
    [DataMember(Name="factor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factor")]
    public float? Factor { get; set; }

    /// <summary>
    /// unity of the part
    /// </summary>
    /// <value>unity of the part</value>
    [DataMember(Name="unity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unity")]
    public Object Unity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPartUnity {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Part: ").Append(Part).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Factor: ").Append(Factor).Append("\n");
      sb.Append("  Unity: ").Append(Unity).Append("\n");
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
