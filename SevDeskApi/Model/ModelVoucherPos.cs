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
  public class ModelVoucherPos {
    /// <summary>
    /// date the voucher positions was created
    /// </summary>
    /// <value>date the voucher positions was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the voucher position was last updated
    /// </summary>
    /// <value>date the voucher position was last updated</value>
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
    /// voucher to which the position belongs
    /// </summary>
    /// <value>voucher to which the position belongs</value>
    [DataMember(Name="voucher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucher")]
    public ModelVoucher Voucher { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingType")]
    public ModelAccountingType AccountingType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="estimatedAccountingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "estimatedAccountingType")]
    public ModelAccountingType EstimatedAccountingType { get; set; }

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
    [DataMember(Name="sum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sum")]
    public float? Sum { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="net", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "net")]
    public bool? Net { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="isAsset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAsset")]
    public bool? IsAsset { get; set; }

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
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="isGwg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGwg")]
    public bool? IsGwg { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="cateringTaxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cateringTaxRate")]
    public float? CateringTaxRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="cateringTip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cateringTip")]
    public float? CateringTip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVoucherPos {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Voucher: ").Append(Voucher).Append("\n");
      sb.Append("  AccountingType: ").Append(AccountingType).Append("\n");
      sb.Append("  EstimatedAccountingType: ").Append(EstimatedAccountingType).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  Sum: ").Append(Sum).Append("\n");
      sb.Append("  Net: ").Append(Net).Append("\n");
      sb.Append("  IsAsset: ").Append(IsAsset).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumTax: ").Append(SumTax).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  SumNetAccounting: ").Append(SumNetAccounting).Append("\n");
      sb.Append("  SumTaxAccounting: ").Append(SumTaxAccounting).Append("\n");
      sb.Append("  SumGrossAccounting: ").Append(SumGrossAccounting).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  IsGwg: ").Append(IsGwg).Append("\n");
      sb.Append("  CateringTaxRate: ").Append(CateringTaxRate).Append("\n");
      sb.Append("  CateringTip: ").Append(CateringTip).Append("\n");
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
