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
  public class ModelCategory {
    /// <summary>
    /// creation date of the category
    /// </summary>
    /// <value>creation date of the category</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the category was last updated
    /// </summary>
    /// <value>date the category was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public ModelCategory Parent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public string ObjectType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="postingAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postingAccount")]
    public string PostingAccount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="translationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translationCode")]
    public string TranslationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public ModelEntryType EntryType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCategory {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  PostingAccount: ").Append(PostingAccount).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TranslationCode: ").Append(TranslationCode).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
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
