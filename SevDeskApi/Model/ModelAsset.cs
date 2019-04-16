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
  public class ModelAsset {
    /// <summary>
    /// date the asset was created
    /// </summary>
    /// <value>date the asset was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the asset was last updated
    /// </summary>
    /// <value>date the asset was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// voucher position of the asset
    /// </summary>
    /// <value>voucher position of the asset</value>
    [DataMember(Name="voucherPos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucherPos")]
    public ModelVoucherPos VoucherPos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// lifespan of the asset
    /// </summary>
    /// <value>lifespan of the asset</value>
    [DataMember(Name="usefulLife", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usefulLife")]
    public int? UsefulLife { get; set; }

    /// <summary>
    /// date the asset was acquired
    /// </summary>
    /// <value>date the asset was acquired</value>
    [DataMember(Name="acquisitionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acquisitionDate")]
    public DateTime? AcquisitionDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="purchasePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasePrice")]
    public float? PurchasePrice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="purchasePriceAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasePriceAccounting")]
    public float? PurchasePriceAccounting { get; set; }

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
    [DataMember(Name="assetNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assetNumber")]
    public string AssetNumber { get; set; }

    /// <summary>
    /// accounting type of the asset
    /// </summary>
    /// <value>accounting type of the asset</value>
    [DataMember(Name="accountingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingType")]
    public ModelAccountingType AccountingType { get; set; }

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
    [DataMember(Name="enshrined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enshrined")]
    public bool? Enshrined { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAsset {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  VoucherPos: ").Append(VoucherPos).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  UsefulLife: ").Append(UsefulLife).Append("\n");
      sb.Append("  AcquisitionDate: ").Append(AcquisitionDate).Append("\n");
      sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
      sb.Append("  PurchasePriceAccounting: ").Append(PurchasePriceAccounting).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
      sb.Append("  AccountingType: ").Append(AccountingType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Enshrined: ").Append(Enshrined).Append("\n");
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
