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
  public class ModelCheckAccount {
    /// <summary>
    /// date the CheckAccount was created
    /// </summary>
    /// <value>date the CheckAccount was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the CheckAccount was last updated
    /// </summary>
    /// <value>date the CheckAccount was last updated</value>
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
    /// name of the CheckAccount
    /// </summary>
    /// <value>name of the CheckAccount</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// type of the CheckAccount
    /// </summary>
    /// <value>type of the CheckAccount</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="importType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importType")]
    public string ImportType { get; set; }

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
    [DataMember(Name="checkAccId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkAccId")]
    public string CheckAccId { get; set; }

    /// <summary>
    /// boolean showing whether this account is the default account or not
    /// </summary>
    /// <value>boolean showing whether this account is the default account or not</value>
    [DataMember(Name="defaultAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultAccount")]
    public string DefaultAccount { get; set; }

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
    [DataMember(Name="translationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translationCode")]
    public string TranslationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="bankServer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bankServer")]
    public string BankServer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public float? Balance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="accountingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountingNumber")]
    public int? AccountingNumber { get; set; }

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
    [DataMember(Name="bic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bic")]
    public string Bic { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="baseAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseAccount")]
    public bool? BaseAccount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public float? Priority { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCheckAccount {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ImportType: ").Append(ImportType).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CheckAccId: ").Append(CheckAccId).Append("\n");
      sb.Append("  DefaultAccount: ").Append(DefaultAccount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TranslationCode: ").Append(TranslationCode).Append("\n");
      sb.Append("  BankServer: ").Append(BankServer).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  AccountingNumber: ").Append(AccountingNumber).Append("\n");
      sb.Append("  Iban: ").Append(Iban).Append("\n");
      sb.Append("  Bic: ").Append(Bic).Append("\n");
      sb.Append("  BaseAccount: ").Append(BaseAccount).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
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
