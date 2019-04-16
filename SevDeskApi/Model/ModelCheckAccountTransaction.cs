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
  public class ModelCheckAccountTransaction {
    /// <summary>
    /// date the check account transaction was created
    /// </summary>
    /// <value>date the check account transaction was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the check account transaction was last updated
    /// </summary>
    /// <value>date the check account transaction was last updated</value>
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
    [DataMember(Name="valueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueDate")]
    public DateTime? ValueDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryDate")]
    public DateTime? EntryDate { get; set; }

    /// <summary>
    /// amount of the transaction
    /// </summary>
    /// <value>amount of the transaction</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="gvCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gvCode")]
    public string GvCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryText")]
    public string EntryText { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="primaNotaNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaNotaNo")]
    public string PrimaNotaNo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="paymtPurpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymtPurpose")]
    public string PaymtPurpose { get; set; }

    /// <summary>
    /// payer bank code
    /// </summary>
    /// <value>payer bank code</value>
    [DataMember(Name="payeePayerBankCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payeePayerBankCode")]
    public string PayeePayerBankCode { get; set; }

    /// <summary>
    /// payer account number
    /// </summary>
    /// <value>payer account number</value>
    [DataMember(Name="payeePayerAcctNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payeePayerAcctNo")]
    public string PayeePayerAcctNo { get; set; }

    /// <summary>
    /// payer name
    /// </summary>
    /// <value>payer name</value>
    [DataMember(Name="payeePayerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payeePayerName")]
    public string PayeePayerName { get; set; }

    /// <summary>
    /// id of the check account
    /// </summary>
    /// <value>id of the check account</value>
    [DataMember(Name="checkAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkAccount")]
    public ModelCheckAccount CheckAccount { get; set; }

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
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public string Score { get; set; }

    /// <summary>
    /// hash to be compared
    /// </summary>
    /// <value>hash to be compared</value>
    [DataMember(Name="compareHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compareHash")]
    public string CompareHash { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public Object EntryType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="enshrined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enshrined")]
    public bool? Enshrined { get; set; }

    /// <summary>
    /// source check account transaction used for transfers
    /// </summary>
    /// <value>source check account transaction used for transfers</value>
    [DataMember(Name="sourceTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceTransaction")]
    public Object SourceTransaction { get; set; }

    /// <summary>
    /// destination check account transaction used for transfers
    /// </summary>
    /// <value>destination check account transaction used for transfers</value>
    [DataMember(Name="targetTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetTransaction")]
    public Object TargetTransaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="obonoReceiptUuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obonoReceiptUuid")]
    public string ObonoReceiptUuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCheckAccountTransaction {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
      sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  GvCode: ").Append(GvCode).Append("\n");
      sb.Append("  EntryText: ").Append(EntryText).Append("\n");
      sb.Append("  PrimaNotaNo: ").Append(PrimaNotaNo).Append("\n");
      sb.Append("  PaymtPurpose: ").Append(PaymtPurpose).Append("\n");
      sb.Append("  PayeePayerBankCode: ").Append(PayeePayerBankCode).Append("\n");
      sb.Append("  PayeePayerAcctNo: ").Append(PayeePayerAcctNo).Append("\n");
      sb.Append("  PayeePayerName: ").Append(PayeePayerName).Append("\n");
      sb.Append("  CheckAccount: ").Append(CheckAccount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  CompareHash: ").Append(CompareHash).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  Enshrined: ").Append(Enshrined).Append("\n");
      sb.Append("  SourceTransaction: ").Append(SourceTransaction).Append("\n");
      sb.Append("  TargetTransaction: ").Append(TargetTransaction).Append("\n");
      sb.Append("  ObonoReceiptUuid: ").Append(ObonoReceiptUuid).Append("\n");
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
