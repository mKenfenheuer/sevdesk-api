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
  public class ModelCheckAccountTransactionLog {
    /// <summary>
    /// date the check account transaction log was created
    /// </summary>
    /// <value>date the check account transaction log was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// the check account transaction to which the log refers
    /// </summary>
    /// <value>the check account transaction to which the log refers</value>
    [DataMember(Name="checkAccountTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkAccountTransaction")]
    public ModelCheckAccountTransaction CheckAccountTransaction { get; set; }

    /// <summary>
    /// the status before the logged change
    /// </summary>
    /// <value>the status before the logged change</value>
    [DataMember(Name="fromStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromStatus")]
    public int? FromStatus { get; set; }

    /// <summary>
    /// the status after the logged change
    /// </summary>
    /// <value>the status after the logged change</value>
    [DataMember(Name="toStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toStatus")]
    public int? ToStatus { get; set; }

    /// <summary>
    /// the logged amount which was paid
    /// </summary>
    /// <value>the logged amount which was paid</value>
    [DataMember(Name="amountPaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountPaid")]
    public float? AmountPaid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="bookingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingDate")]
    public DateTime? BookingDate { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// Invoice/Voucher to which the logged transaction belongs
    /// </summary>
    /// <value>Invoice/Voucher to which the logged transaction belongs</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelCheckAccountTransactionLog {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  CheckAccountTransaction: ").Append(CheckAccountTransaction).Append("\n");
      sb.Append("  FromStatus: ").Append(FromStatus).Append("\n");
      sb.Append("  ToStatus: ").Append(ToStatus).Append("\n");
      sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
      sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
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
