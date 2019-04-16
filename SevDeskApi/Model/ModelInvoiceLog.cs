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
  public class ModelInvoiceLog {
    /// <summary>
    /// date the invoice log was created
    /// </summary>
    /// <value>date the invoice log was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// the invoice which is logged
    /// </summary>
    /// <value>the invoice which is logged</value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public Object Invoice { get; set; }

    /// <summary>
    /// status before the change
    /// </summary>
    /// <value>status before the change</value>
    [DataMember(Name="fromStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromStatus")]
    public int? FromStatus { get; set; }

    /// <summary>
    /// status after the change
    /// </summary>
    /// <value>status after the change</value>
    [DataMember(Name="toStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toStatus")]
    public int? ToStatus { get; set; }

    /// <summary>
    /// amount that was payed
    /// </summary>
    /// <value>amount that was payed</value>
    [DataMember(Name="ammountPayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammountPayed")]
    public float? AmmountPayed { get; set; }

    /// <summary>
    /// date of the booking
    /// </summary>
    /// <value>date of the booking</value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelInvoiceLog {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  FromStatus: ").Append(FromStatus).Append("\n");
      sb.Append("  ToStatus: ").Append(ToStatus).Append("\n");
      sb.Append("  AmmountPayed: ").Append(AmmountPayed).Append("\n");
      sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
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
