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
  public class ModelLetter {
    /// <summary>
    /// creation date of the letter
    /// </summary>
    /// <value>creation date of the letter</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the letter was last updated
    /// </summary>
    /// <value>date the letter was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="letterNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "letterNumber")]
    public string LetterNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public ModelContact Contact { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="letterDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "letterDate")]
    public DateTime? LetterDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header")]
    public string Header { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressName")]
    public string AddressName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressName2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressName2")]
    public string AddressName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressStreet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressStreet")]
    public string AddressStreet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressZip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressZip")]
    public string AddressZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressCity")]
    public string AddressCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressCountry")]
    public ModelStaticCountry AddressCountry { get; set; }

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
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contactPerson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contactPerson")]
    public ModelSevUser ContactPerson { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressParentName")]
    public string AddressParentName { get; set; }

    /// <summary>
    /// reference to Model_ContactAddress
    /// </summary>
    /// <value>reference to Model_ContactAddress</value>
    [DataMember(Name="addressContactRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressContactRef")]
    public ModelContactAddress AddressContactRef { get; set; }

    /// <summary>
    /// text for the letter
    /// </summary>
    /// <value>text for the letter</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sendDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendDate")]
    public DateTime? SendDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressParentName2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressParentName2")]
    public string AddressParentName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressGender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressGender")]
    public string AddressGender { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sendType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendType")]
    public string SendType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelLetter {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  LetterNumber: ").Append(LetterNumber).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  LetterDate: ").Append(LetterDate).Append("\n");
      sb.Append("  Header: ").Append(Header).Append("\n");
      sb.Append("  AddressName: ").Append(AddressName).Append("\n");
      sb.Append("  AddressName2: ").Append(AddressName2).Append("\n");
      sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
      sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
      sb.Append("  AddressParentName: ").Append(AddressParentName).Append("\n");
      sb.Append("  AddressContactRef: ").Append(AddressContactRef).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  AddressParentName2: ").Append(AddressParentName2).Append("\n");
      sb.Append("  AddressGender: ").Append(AddressGender).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  SendType: ").Append(SendType).Append("\n");
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
