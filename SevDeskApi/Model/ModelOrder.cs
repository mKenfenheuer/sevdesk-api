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
  public class ModelOrder {
    /// <summary>
    /// date the order was created
    /// </summary>
    /// <value>date the order was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the order was last updated
    /// </summary>
    /// <value>date the order was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="oderNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oderNumber")]
    public string OderNumber { get; set; }

    /// <summary>
    /// the Model_Contact which is linked to the order
    /// </summary>
    /// <value>the Model_Contact which is linked to the order</value>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public ModelContact Contact { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="orderDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderDate")]
    public DateTime? OrderDate { get; set; }

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
    [DataMember(Name="header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header")]
    public string Header { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="headText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headText")]
    public string HeadText { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="footText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "footText")]
    public string FootText { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="createUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createUser")]
    public ModelSevUser CreateUser { get; set; }

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
    [DataMember(Name="deliveryTerms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryTerms")]
    public string DeliveryTerms { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="paymentTerms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentTerms")]
    public string PaymentTerms { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public Object Origin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="smallSettlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smallSettlement")]
    public bool? SmallSettlement { get; set; }

    /// <summary>
    /// contact person for the order which is a SevUser
    /// </summary>
    /// <value>contact person for the order which is a SevUser</value>
    [DataMember(Name="contactPerson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contactPerson")]
    public ModelSevUser ContactPerson { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="taxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRate")]
    public float? TaxRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="taxSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxSet")]
    public ModelTaxSet TaxSet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="taxText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxText")]
    public string TaxText { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressParentName")]
    public string AddressParentName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressContactRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressContactRef")]
    public ModelContactAddress AddressContactRef { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="taxType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxType")]
    public string TaxType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="orderType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderType")]
    public string OrderType { get; set; }

    /// <summary>
    /// date the order was sent
    /// </summary>
    /// <value>date the order was sent</value>
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
    [DataMember(Name="addressName2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressName2")]
    public string AddressName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="addressGender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressGender")]
    public string AddressGender { get; set; }

    /// <summary>
    /// concatenation of address attributes acquired from Model_Contact->Model_ContactAddress
    /// </summary>
    /// <value>concatenation of address attributes acquired from Model_Contact->Model_ContactAddress</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public ModelContactAddress Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNet")]
    public float? SumNet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumTax")]
    public float? SumTax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGross")]
    public float? SumGross { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumDiscounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumDiscounts")]
    public float? SumDiscounts { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumNetForeignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNetForeignCurrency")]
    public float? SumNetForeignCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumTaxForeignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumTaxForeignCurrency")]
    public float? SumTaxForeignCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumGrossForeignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGrossForeignCurrency")]
    public float? SumGrossForeignCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumDiscountsForeignCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumDiscountsForeignCurrency")]
    public float? SumDiscountsForeignCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public float? Weight { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public ModelEntryType EntryType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="costumerInternalNote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costumerInternalNote")]
    public string CostumerInternalNote { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="showNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showNet")]
    public bool? ShowNet { get; set; }

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
      sb.Append("class ModelOrder {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  OderNumber: ").Append(OderNumber).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Header: ").Append(Header).Append("\n");
      sb.Append("  HeadText: ").Append(HeadText).Append("\n");
      sb.Append("  FootText: ").Append(FootText).Append("\n");
      sb.Append("  AddressName: ").Append(AddressName).Append("\n");
      sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
      sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  DeliveryTerms: ").Append(DeliveryTerms).Append("\n");
      sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  SmallSettlement: ").Append(SmallSettlement).Append("\n");
      sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  TaxSet: ").Append(TaxSet).Append("\n");
      sb.Append("  TaxText: ").Append(TaxText).Append("\n");
      sb.Append("  AddressParentName: ").Append(AddressParentName).Append("\n");
      sb.Append("  AddressContactRef: ").Append(AddressContactRef).Append("\n");
      sb.Append("  TaxType: ").Append(TaxType).Append("\n");
      sb.Append("  OrderType: ").Append(OrderType).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  AddressParentName2: ").Append(AddressParentName2).Append("\n");
      sb.Append("  AddressName2: ").Append(AddressName2).Append("\n");
      sb.Append("  AddressGender: ").Append(AddressGender).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumTax: ").Append(SumTax).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  SumDiscounts: ").Append(SumDiscounts).Append("\n");
      sb.Append("  SumNetForeignCurrency: ").Append(SumNetForeignCurrency).Append("\n");
      sb.Append("  SumTaxForeignCurrency: ").Append(SumTaxForeignCurrency).Append("\n");
      sb.Append("  SumGrossForeignCurrency: ").Append(SumGrossForeignCurrency).Append("\n");
      sb.Append("  SumDiscountsForeignCurrency: ").Append(SumDiscountsForeignCurrency).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  CostumerInternalNote: ").Append(CostumerInternalNote).Append("\n");
      sb.Append("  ShowNet: ").Append(ShowNet).Append("\n");
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
