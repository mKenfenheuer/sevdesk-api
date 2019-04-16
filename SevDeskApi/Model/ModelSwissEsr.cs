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
  public class ModelSwissEsr {
    /// <summary>
    /// date the swiss esr was created
    /// </summary>
    /// <value>date the swiss esr was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the swiss esr was last updated
    /// </summary>
    /// <value>date the swiss esr was last updated</value>
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
    [DataMember(Name="addressCityCredit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressCityCredit")]
    public string AddressCityCredit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressZipCredit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressZipCredit")]
    public string AddressZipCredit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="postSubscriberNumberBank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postSubscriberNumberBank")]
    public string PostSubscriberNumberBank { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="internalSubscriberNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalSubscriberNumber")]
    public string InternalSubscriberNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="documentTypeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentTypeCode")]
    public string DocumentTypeCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="isEsr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEsr")]
    public int? IsEsr { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSwissEsr {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  AddressCityCredit: ").Append(AddressCityCredit).Append("\n");
      sb.Append("  AddressZipCredit: ").Append(AddressZipCredit).Append("\n");
      sb.Append("  PostSubscriberNumberBank: ").Append(PostSubscriberNumberBank).Append("\n");
      sb.Append("  InternalSubscriberNumber: ").Append(InternalSubscriberNumber).Append("\n");
      sb.Append("  DocumentTypeCode: ").Append(DocumentTypeCode).Append("\n");
      sb.Append("  IsEsr: ").Append(IsEsr).Append("\n");
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
