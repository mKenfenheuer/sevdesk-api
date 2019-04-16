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
  public class ModelTaxSet {
    /// <summary>
    /// date the tax set was created
    /// </summary>
    /// <value>date the tax set was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the tax set was last updated
    /// </summary>
    /// <value>date the tax set was last updated</value>
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
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

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
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public float? Code { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="displayText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayText")]
    public string DisplayText { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vatReportFieldNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatReportFieldNet")]
    public string VatReportFieldNet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vatReportFieldTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vatReportFieldTax")]
    public string VatReportFieldTax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingExportVatField", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingExportVatField")]
    public string AccountingExportVatField { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="showInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showInvoice")]
    public bool? ShowInvoice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="showDebitVoucher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showDebitVoucher")]
    public bool? ShowDebitVoucher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="showCreditVoucher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showCreditVoucher")]
    public bool? ShowCreditVoucher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="onlyForVatDec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onlyForVatDec")]
    public bool? OnlyForVatDec { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelTaxSet {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
      sb.Append("  VatReportFieldNet: ").Append(VatReportFieldNet).Append("\n");
      sb.Append("  VatReportFieldTax: ").Append(VatReportFieldTax).Append("\n");
      sb.Append("  AccountingExportVatField: ").Append(AccountingExportVatField).Append("\n");
      sb.Append("  ShowInvoice: ").Append(ShowInvoice).Append("\n");
      sb.Append("  ShowDebitVoucher: ").Append(ShowDebitVoucher).Append("\n");
      sb.Append("  ShowCreditVoucher: ").Append(ShowCreditVoucher).Append("\n");
      sb.Append("  OnlyForVatDec: ").Append(OnlyForVatDec).Append("\n");
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
