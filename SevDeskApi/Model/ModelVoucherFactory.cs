using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// Below are the models which can be used for the saveVoucher function. Beware that you need to use them without the underscore at the beginning!
  /// </summary>
  [DataContract]
  public class ModelVoucherFactory {
    /// <summary>
    /// the Model_Voucher to create/update
    /// </summary>
    /// <value>the Model_Voucher to create/update</value>
    [DataMember(Name="voucher[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucher[]")]
    public ModelVoucher Voucher { get; set; }

    /// <summary>
    /// the Model_VoucherPos to create/update
    /// </summary>
    /// <value>the Model_VoucherPos to create/update</value>
    [DataMember(Name="voucherPosSave[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucherPosSave[]")]
    public ModelVoucherPos VoucherPosSave { get; set; }

    /// <summary>
    /// the Model_VoucherPos to delete
    /// </summary>
    /// <value>the Model_VoucherPos to delete</value>
    [DataMember(Name="voucherPosDelete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "voucherPosDelete")]
    public ModelVoucherPos VoucherPosDelete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelVoucherFactory {\n");
      sb.Append("  Voucher: ").Append(Voucher).Append("\n");
      sb.Append("  VoucherPosSave: ").Append(VoucherPosSave).Append("\n");
      sb.Append("  VoucherPosDelete: ").Append(VoucherPosDelete).Append("\n");
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
