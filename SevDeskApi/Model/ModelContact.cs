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
  public class ModelContact {
    /// <summary>
    /// the contact address
    /// </summary>
    /// <value>the contact address</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public ModelContactAddress Address { get; set; }

    /// <summary>
    /// the creation date of the contact
    /// </summary>
    /// <value>the creation date of the contact</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date, the contact was last updated
    /// </summary>
    /// <value>date, the contact was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// name of the contact
    /// </summary>
    /// <value>name of the contact</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// status of the contact
    /// </summary>
    /// <value>status of the contact</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// customer number of the contact
    /// </summary>
    /// <value>customer number of the contact</value>
    [DataMember(Name="customerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerNumber")]
    public int? CustomerNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public ModelContact Parent { get; set; }

    /// <summary>
    /// surname of the contact
    /// </summary>
    /// <value>surname of the contact</value>
    [DataMember(Name="surename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surename")]
    public string Surename { get; set; }

    /// <summary>
    /// family name of the contact
    /// </summary>
    /// <value>family name of the contact</value>
    [DataMember(Name="familyname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "familyname")]
    public string Familyname { get; set; }

    /// <summary>
    /// title of the contact
    /// </summary>
    /// <value>title of the contact</value>
    [DataMember(Name="titel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titel")]
    public string Titel { get; set; }

    /// <summary>
    /// category of the contact
    /// </summary>
    /// <value>category of the contact</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public ModelCategory Category { get; set; }

    /// <summary>
    /// description of the contact
    /// </summary>
    /// <value>description of the contact</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// any academic title of the contact
    /// </summary>
    /// <value>any academic title of the contact</value>
    [DataMember(Name="academicTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "academicTitle")]
    public string AcademicTitle { get; set; }

    /// <summary>
    /// gender of the contact
    /// </summary>
    /// <value>gender of the contact</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// second name of the contact
    /// </summary>
    /// <value>second name of the contact</value>
    [DataMember(Name="name2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name2")]
    public string Name2 { get; set; }

    /// <summary>
    /// birthday of the contact
    /// </summary>
    /// <value>birthday of the contact</value>
    [DataMember(Name="birthday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthday")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// vat number of the contact
    /// </summary>
    /// <value>vat number of the contact</value>
    [DataMember(Name="vatNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatNumber")]
    public string VatNumber { get; set; }

    /// <summary>
    /// bank account of the contact
    /// </summary>
    /// <value>bank account of the contact</value>
    [DataMember(Name="bankAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankAccount")]
    public string BankAccount { get; set; }

    /// <summary>
    /// bank number of the contact
    /// </summary>
    /// <value>bank number of the contact</value>
    [DataMember(Name="bankNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankNumber")]
    public string BankNumber { get; set; }

    /// <summary>
    /// desired payment method of the customer
    /// </summary>
    /// <value>desired payment method of the customer</value>
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public ModelPaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public ModelEntryType EntryType { get; set; }

    /// <summary>
    /// default cashback time of the contact
    /// </summary>
    /// <value>default cashback time of the contact</value>
    [DataMember(Name="defaultCashbackTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultCashbackTime")]
    public int? DefaultCashbackTime { get; set; }

    /// <summary>
    /// default cashback percentage of the contact
    /// </summary>
    /// <value>default cashback percentage of the contact</value>
    [DataMember(Name="defaultCashbackPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultCashbackPercent")]
    public int? DefaultCashbackPercent { get; set; }

    /// <summary>
    /// default time to pay of the contact
    /// </summary>
    /// <value>default time to pay of the contact</value>
    [DataMember(Name="defaultTimeToPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTimeToPay")]
    public int? DefaultTimeToPay { get; set; }

    /// <summary>
    /// tax number of the contact
    /// </summary>
    /// <value>tax number of the contact</value>
    [DataMember(Name="taxNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxNumber")]
    public string TaxNumber { get; set; }

    /// <summary>
    /// tax office of the contact
    /// </summary>
    /// <value>tax office of the contact</value>
    [DataMember(Name="taxOffice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxOffice")]
    public string TaxOffice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelContact {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Surename: ").Append(Surename).Append("\n");
      sb.Append("  Familyname: ").Append(Familyname).Append("\n");
      sb.Append("  Titel: ").Append(Titel).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  AcademicTitle: ").Append(AcademicTitle).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Name2: ").Append(Name2).Append("\n");
      sb.Append("  Birthday: ").Append(Birthday).Append("\n");
      sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
      sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
      sb.Append("  BankNumber: ").Append(BankNumber).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  DefaultCashbackTime: ").Append(DefaultCashbackTime).Append("\n");
      sb.Append("  DefaultCashbackPercent: ").Append(DefaultCashbackPercent).Append("\n");
      sb.Append("  DefaultTimeToPay: ").Append(DefaultTimeToPay).Append("\n");
      sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
      sb.Append("  TaxOffice: ").Append(TaxOffice).Append("\n");
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
