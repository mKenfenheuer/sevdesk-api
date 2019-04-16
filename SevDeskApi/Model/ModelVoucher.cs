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
  public class ModelVoucher {
    /// <summary>
    /// date the voucher was created
    /// </summary>
    /// <value>date the voucher was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the voucher was last updated
    /// </summary>
    /// <value>date the voucher was last updated</value>
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
    /// sevUser who created the voucher
    /// </summary>
    /// <value>sevUser who created the voucher</value>
    [DataMember(Name="createUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createUser")]
    public ModelSevUser CreateUser { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="voucherDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucherDate")]
    public DateTime? VoucherDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="supplier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier")]
    public ModelContact Supplier { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="supplierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplierName")]
    public string SupplierName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document")]
    public ModelDocument Document { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="resultDisdar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultDisdar")]
    public string ResultDisdar { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="documentPreview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentPreview")]
    public ModelDocument DocumentPreview { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="payDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payDate")]
    public DateTime? PayDate { get; set; }

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
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }

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
    [DataMember(Name="taxType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxType")]
    public string TaxType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="creditDebit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditDebit")]
    public string CreditDebit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

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
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public Object Origin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="voucherType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucherType")]
    public string VoucherType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="recurringIntervall", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringIntervall")]
    public int? RecurringIntervall { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="recurringStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringStartDate")]
    public DateTime? RecurringStartDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="recurringNextVoucher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringNextVoucher")]
    public DateTime? RecurringNextVoucher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="recurringLastVoucher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringLastVoucher")]
    public DateTime? RecurringLastVoucher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="recurringEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recurringEndDate")]
    public DateTime? RecurringEndDate { get; set; }

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
    [DataMember(Name="inSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inSource")]
    public string InSource { get; set; }

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
    [DataMember(Name="iban", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iban")]
    public string Iban { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingSpecialCase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingSpecialCase")]
    public string AccountingSpecialCase { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="paymentDeadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentDeadline")]
    public DateTime? PaymentDeadline { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="tip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tip")]
    public float? Tip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVoucher {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  VoucherDate: ").Append(VoucherDate).Append("\n");
      sb.Append("  Supplier: ").Append(Supplier).Append("\n");
      sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Document: ").Append(Document).Append("\n");
      sb.Append("  ResultDisdar: ").Append(ResultDisdar).Append("\n");
      sb.Append("  DocumentPreview: ").Append(DocumentPreview).Append("\n");
      sb.Append("  PayDate: ").Append(PayDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumTax: ").Append(SumTax).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  SumNetAccounting: ").Append(SumNetAccounting).Append("\n");
      sb.Append("  SumTaxAccounting: ").Append(SumTaxAccounting).Append("\n");
      sb.Append("  SumGrossAccounting: ").Append(SumGrossAccounting).Append("\n");
      sb.Append("  TaxType: ").Append(TaxType).Append("\n");
      sb.Append("  CreditDebit: ").Append(CreditDebit).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  CostCentre: ").Append(CostCentre).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
      sb.Append("  RecurringIntervall: ").Append(RecurringIntervall).Append("\n");
      sb.Append("  RecurringStartDate: ").Append(RecurringStartDate).Append("\n");
      sb.Append("  RecurringNextVoucher: ").Append(RecurringNextVoucher).Append("\n");
      sb.Append("  RecurringLastVoucher: ").Append(RecurringLastVoucher).Append("\n");
      sb.Append("  RecurringEndDate: ").Append(RecurringEndDate).Append("\n");
      sb.Append("  Enshrined: ").Append(Enshrined).Append("\n");
      sb.Append("  InSource: ").Append(InSource).Append("\n");
      sb.Append("  TaxSet: ").Append(TaxSet).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  AccountingSpecialCase: ").Append(AccountingSpecialCase).Append("\n");
      sb.Append("  PaymentDeadline: ").Append(PaymentDeadline).Append("\n");
      sb.Append("  Tip: ").Append(Tip).Append("\n");
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
