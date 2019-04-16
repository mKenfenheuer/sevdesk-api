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
  public class ModelAccountingType {
    /// <summary>
    /// date the accounting type was created
    /// </summary>
    /// <value>date the accounting type was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the accounting type was last updated
    /// </summary>
    /// <value>date the accounting type was last updated</value>
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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public ModelAccountingType Parent { get; set; }

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
    [DataMember(Name="skr03", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skr03")]
    public int? Skr03 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skr03Deprecation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skr03Deprecation")]
    public int? Skr03Deprecation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingChart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingChart")]
    public ModelAccountingChart AccountingChart { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skr04", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skr04")]
    public int? Skr04 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skr04Deprecation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skr04Deprecation")]
    public int? Skr04Deprecation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrAt")]
    public int? SkrAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrAtDeprecation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrAtDeprecation")]
    public int? SkrAtDeprecation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrCh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrCh")]
    public int? SkrCh { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrChDeprecation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrChDeprecation")]
    public int? SkrChDeprecation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrGr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrGr")]
    public int? SkrGr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="skrGrDeprecation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skrGrDeprecation")]
    public int? SkrGrDeprecation { get; set; }

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
    [DataMember(Name="descriptionTranslationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "descriptionTranslationCode")]
    public string DescriptionTranslationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="connotationTranslationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connotationTranslationCode")]
    public string ConnotationTranslationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="bookingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingType")]
    public string BookingType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="assetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assetType")]
    public string AssetType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAccountingType {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Skr03: ").Append(Skr03).Append("\n");
      sb.Append("  Skr03Deprecation: ").Append(Skr03Deprecation).Append("\n");
      sb.Append("  AccountingChart: ").Append(AccountingChart).Append("\n");
      sb.Append("  Skr04: ").Append(Skr04).Append("\n");
      sb.Append("  Skr04Deprecation: ").Append(Skr04Deprecation).Append("\n");
      sb.Append("  SkrAt: ").Append(SkrAt).Append("\n");
      sb.Append("  SkrAtDeprecation: ").Append(SkrAtDeprecation).Append("\n");
      sb.Append("  SkrCh: ").Append(SkrCh).Append("\n");
      sb.Append("  SkrChDeprecation: ").Append(SkrChDeprecation).Append("\n");
      sb.Append("  SkrGr: ").Append(SkrGr).Append("\n");
      sb.Append("  SkrGrDeprecation: ").Append(SkrGrDeprecation).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TranslationCode: ").Append(TranslationCode).Append("\n");
      sb.Append("  DescriptionTranslationCode: ").Append(DescriptionTranslationCode).Append("\n");
      sb.Append("  ConnotationTranslationCode: ").Append(ConnotationTranslationCode).Append("\n");
      sb.Append("  BookingType: ").Append(BookingType).Append("\n");
      sb.Append("  AssetType: ").Append(AssetType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
