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
  public class ModelSevQuery {
    /// <summary>
    /// Name of the model for which you want to make a query
    /// </summary>
    /// <value>Name of the model for which you want to make a query</value>
    [DataMember(Name="modelName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modelName")]
    public string ModelName { get; set; }

    /// <summary>
    /// Limit for the returned entries
    /// </summary>
    /// <value>Limit for the returned entries</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Offset for the returned entries
    /// </summary>
    /// <value>Offset for the returned entries</value>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// Filters that should be applied to the returned entries
    /// </summary>
    /// <value>Filters that should be applied to the returned entries</value>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter")]
    public List<string> Filter { get; set; }

    /// <summary>
    /// Define how returned entries should be sorted
    /// </summary>
    /// <value>Define how returned entries should be sorted</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public string Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSevQuery {\n");
      sb.Append("  ModelName: ").Append(ModelName).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
