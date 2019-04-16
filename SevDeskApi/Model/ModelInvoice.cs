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
  public class ModelInvoice {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// the contact the invoice belongs to
    /// </summary>
    /// <value>the contact the invoice belongs to</value>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public ModelContact Contact { get; set; }

    /// <summary>
    /// the date the invoice was created
    /// </summary>
    /// <value>the date the invoice was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// the date the invoice was last updated
    /// </summary>
    /// <value>the date the invoice was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// the date of the invoice
    /// </summary>
    /// <value>the date of the invoice</value>
    [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// header/subject of the invoice
    /// </summary>
    /// <value>header/subject of the invoice</value>
    [DataMember(Name="header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "header")]
    public string Header { get; set; }

    /// <summary>
    /// head text of the invoice
    /// </summary>
    /// <value>head text of the invoice</value>
    [DataMember(Name="headText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headText")]
    public string HeadText { get; set; }

    /// <summary>
    /// foot text of the invoice
    /// </summary>
    /// <value>foot text of the invoice</value>
    [DataMember(Name="footText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "footText")]
    public string FootText { get; set; }

    /// <summary>
    /// time left for paying the invoice, use format dd.MM.yyyy or number for number of days left
    /// </summary>
    /// <value>time left for paying the invoice, use format dd.MM.yyyy or number for number of days left</value>
    [DataMember(Name="timeToPay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToPay")]
    public DateTime? TimeToPay { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="discountTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountTime")]
    public DateTime? DiscountTime { get; set; }

    /// <summary>
    /// the discount value in '%'
    /// </summary>
    /// <value>the discount value in '%'</value>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public float? Discount { get; set; }

    /// <summary>
    /// the name in the address, equals the contacts name
    /// </summary>
    /// <value>the name in the address, equals the contacts name</value>
    [DataMember(Name="addressName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressName")]
    public string AddressName { get; set; }

    /// <summary>
    /// the street in the address, equals the contacts street
    /// </summary>
    /// <value>the street in the address, equals the contacts street</value>
    [DataMember(Name="addressStreet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressStreet")]
    public string AddressStreet { get; set; }

    /// <summary>
    /// the zip-code in the address, equals the contacts zip
    /// </summary>
    /// <value>the zip-code in the address, equals the contacts zip</value>
    [DataMember(Name="addressZip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressZip")]
    public string AddressZip { get; set; }

    /// <summary>
    /// the city in the address, equals the contacts city
    /// </summary>
    /// <value>the city in the address, equals the contacts city</value>
    [DataMember(Name="addressCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressCity")]
    public string AddressCity { get; set; }

    /// <summary>
    /// the country in the address, equals the contacts country
    /// </summary>
    /// <value>the country in the address, equals the contacts country</value>
    [DataMember(Name="addressCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressCountry")]
    public ModelStaticCountry AddressCountry { get; set; }

    /// <summary>
    /// time left for paying the invoice, use format DD.MM.YYYY or number for number of days left
    /// </summary>
    /// <value>time left for paying the invoice, use format DD.MM.YYYY or number for number of days left</value>
    [DataMember(Name="payDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payDate")]
    public DateTime? PayDate { get; set; }

    /// <summary>
    /// SevUser who created the invoice
    /// </summary>
    /// <value>SevUser who created the invoice</value>
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
    /// delivery date of the goods from the invoice, please use dd.MM.yyyy
    /// </summary>
    /// <value>delivery date of the goods from the invoice, please use dd.MM.yyyy</value>
    [DataMember(Name="deliveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryDate")]
    public DateTime? DeliveryDate { get; set; }

    /// <summary>
    /// status of the invoice
    /// </summary>
    /// <value>status of the invoice</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="smallSettlement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smallSettlement")]
    public bool? SmallSettlement { get; set; }

    /// <summary>
    /// SevUser who created the invoice and therefore is the contact person
    /// </summary>
    /// <value>SevUser who created the invoice and therefore is the contact person</value>
    [DataMember(Name="contactPerson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contactPerson")]
    public ModelSevUser ContactPerson { get; set; }

    /// <summary>
    /// tax rate used when adding a value added tax regulation
    /// </summary>
    /// <value>tax rate used when adding a value added tax regulation</value>
    [DataMember(Name="taxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRate")]
    public float? TaxRate { get; set; }

    /// <summary>
    /// additional text when adding a value added tax regulation
    /// </summary>
    /// <value>additional text when adding a value added tax regulation</value>
    [DataMember(Name="taxText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxText")]
    public string TaxText { get; set; }

    /// <summary>
    /// dunning level of the invoice
    /// </summary>
    /// <value>dunning level of the invoice</value>
    [DataMember(Name="dunningLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dunningLevel")]
    public int? DunningLevel { get; set; }

    /// <summary>
    /// name of the contacts address
    /// </summary>
    /// <value>name of the contacts address</value>
    [DataMember(Name="addressParentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressParentName")]
    public string AddressParentName { get; set; }

    /// <summary>
    /// a reference to the contacts address
    /// </summary>
    /// <value>a reference to the contacts address</value>
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
    [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentMethod")]
    public ModelPaymentMethod PaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="costCentre", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costCentre")]
    public ModelCostCentre CostCentre { get; set; }

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
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public Object Origin { get; set; }

    /// <summary>
    /// type of the invoice
    /// </summary>
    /// <value>type of the invoice</value>
    [DataMember(Name="invoiceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceType")]
    public string InvoiceType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountIntervall", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIntervall")]
    public int? AccountIntervall { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountLastInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountLastInvoice")]
    public DateTime? AccountLastInvoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountNextInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNextInvoice")]
    public DateTime? AccountNextInvoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reminderTotal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderTotal")]
    public float? ReminderTotal { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reminderDebit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderDebit")]
    public float? ReminderDebit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reminderDeadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderDeadline")]
    public DateTime? ReminderDeadline { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="reminderCharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderCharge")]
    public float? ReminderCharge { get; set; }

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
    [DataMember(Name="taxSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxSet")]
    public ModelTaxSet TaxSet { get; set; }

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
    [DataMember(Name="accountEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountEndDate")]
    public DateTime? AccountEndDate { get; set; }

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
    [DataMember(Name="sumNetAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNetAccounting")]
    public float? SumNetAccounting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumTaxAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumTaxAccounting")]
    public float? SumTaxAccounting { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumGrossAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGrossAccounting")]
    public float? SumGrossAccounting { get; set; }

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
    [DataMember(Name="enshrined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enshrined")]
    public bool? Enshrined { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sendType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendType")]
    public string SendType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="deliveryDateUntil", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryDateUntil")]
    public DateTime? DeliveryDateUntil { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelInvoice {\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  Header: ").Append(Header).Append("\n");
      sb.Append("  HeadText: ").Append(HeadText).Append("\n");
      sb.Append("  FootText: ").Append(FootText).Append("\n");
      sb.Append("  TimeToPay: ").Append(TimeToPay).Append("\n");
      sb.Append("  DiscountTime: ").Append(DiscountTime).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  AddressName: ").Append(AddressName).Append("\n");
      sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
      sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
      sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
      sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
      sb.Append("  PayDate: ").Append(PayDate).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SmallSettlement: ").Append(SmallSettlement).Append("\n");
      sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  TaxText: ").Append(TaxText).Append("\n");
      sb.Append("  DunningLevel: ").Append(DunningLevel).Append("\n");
      sb.Append("  AddressParentName: ").Append(AddressParentName).Append("\n");
      sb.Append("  AddressContactRef: ").Append(AddressContactRef).Append("\n");
      sb.Append("  TaxType: ").Append(TaxType).Append("\n");
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      sb.Append("  CostCentre: ").Append(CostCentre).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
      sb.Append("  AccountIntervall: ").Append(AccountIntervall).Append("\n");
      sb.Append("  AccountLastInvoice: ").Append(AccountLastInvoice).Append("\n");
      sb.Append("  AccountNextInvoice: ").Append(AccountNextInvoice).Append("\n");
      sb.Append("  ReminderTotal: ").Append(ReminderTotal).Append("\n");
      sb.Append("  ReminderDebit: ").Append(ReminderDebit).Append("\n");
      sb.Append("  ReminderDeadline: ").Append(ReminderDeadline).Append("\n");
      sb.Append("  ReminderCharge: ").Append(ReminderCharge).Append("\n");
      sb.Append("  AddressParentName2: ").Append(AddressParentName2).Append("\n");
      sb.Append("  AddressName2: ").Append(AddressName2).Append("\n");
      sb.Append("  TaxSet: ").Append(TaxSet).Append("\n");
      sb.Append("  AddressGender: ").Append(AddressGender).Append("\n");
      sb.Append("  AccountEndDate: ").Append(AccountEndDate).Append("\n");
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
      sb.Append("  SumNetAccounting: ").Append(SumNetAccounting).Append("\n");
      sb.Append("  SumTaxAccounting: ").Append(SumTaxAccounting).Append("\n");
      sb.Append("  SumGrossAccounting: ").Append(SumGrossAccounting).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  CostumerInternalNote: ").Append(CostumerInternalNote).Append("\n");
      sb.Append("  ShowNet: ").Append(ShowNet).Append("\n");
      sb.Append("  Enshrined: ").Append(Enshrined).Append("\n");
      sb.Append("  SendType: ").Append(SendType).Append("\n");
      sb.Append("  DeliveryDateUntil: ").Append(DeliveryDateUntil).Append("\n");
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
