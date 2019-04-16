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
  public class ModelTextTemplate {
    /// <summary>
    /// date the text template was created
    /// </summary>
    /// <value>date the text template was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the text template was last updated
    /// </summary>
    /// <value>date the text template was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// name of the text template
    /// </summary>
    /// <value>name of the text template</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// text of your text template
    /// </summary>
    /// <value>text of your text template</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// object type for which you want to use the text template
    /// </summary>
    /// <value>object type for which you want to use the text template</value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public string ObjectType { get; set; }

    /// <summary>
    /// type of your text
    /// </summary>
    /// <value>type of your text</value>
    [DataMember(Name="textType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textType")]
    public string TextType { get; set; }

    /// <summary>
    /// sevUser who created the text template
    /// </summary>
    /// <value>sevUser who created the text template</value>
    [DataMember(Name="sevUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevUser")]
    public Object SevUser { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// defines if the text template is used as the main template
    /// </summary>
    /// <value>defines if the text template is used as the main template</value>
    [DataMember(Name="main", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "main")]
    public bool? Main { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelTextTemplate {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  TextType: ").Append(TextType).Append("\n");
      sb.Append("  SevUser: ").Append(SevUser).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Main: ").Append(Main).Append("\n");
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
