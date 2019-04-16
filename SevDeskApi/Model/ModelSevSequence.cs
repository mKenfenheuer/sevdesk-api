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
  public class ModelSevSequence {
    /// <summary>
    /// date the SevSequence was created
    /// </summary>
    /// <value>date the SevSequence was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the SevSequence was last updated
    /// </summary>
    /// <value>date the SevSequence was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// Object for which the sequence is
    /// </summary>
    /// <value>Object for which the sequence is</value>
    [DataMember(Name="forObject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forObject")]
    public string ForObject { get; set; }

    /// <summary>
    /// Format of the sequence
    /// </summary>
    /// <value>Format of the sequence</value>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }

    /// <summary>
    /// next sequence of the object
    /// </summary>
    /// <value>next sequence of the object</value>
    [DataMember(Name="nextSequence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextSequence")]
    public int? NextSequence { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// type of the object
    /// </summary>
    /// <value>type of the object</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSevSequence {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  ForObject: ").Append(ForObject).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  NextSequence: ").Append(NextSequence).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
