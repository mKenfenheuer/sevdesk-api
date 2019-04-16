using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// Below are the models which can be used for the functions in Invoice/Factory.php. Beware that you need to use them without the underscore at the beginning!
  /// </summary>
  [DataContract]
  public class ModelInvoiceFactory {
    /// <summary>
    /// the Model_Invoice to create/update
    /// </summary>
    /// <value>the Model_Invoice to create/update</value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public ModelInvoice Invoice { get; set; }

    /// <summary>
    /// the Model_InvoicePos to create/update
    /// </summary>
    /// <value>the Model_InvoicePos to create/update</value>
    [DataMember(Name="invoicePosSave[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoicePosSave[]")]
    public ModelInvoice InvoicePosSave { get; set; }

    /// <summary>
    /// the Model_InvoicePos to delete
    /// </summary>
    /// <value>the Model_InvoicePos to delete</value>
    [DataMember(Name="invoicePosDelete[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoicePosDelete[]")]
    public ModelInvoice InvoicePosDelete { get; set; }

    /// <summary>
    /// the Model_Discounts to create/update
    /// </summary>
    /// <value>the Model_Discounts to create/update</value>
    [DataMember(Name="discountSave[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountSave[]")]
    public ModelDiscounts DiscountSave { get; set; }

    /// <summary>
    /// the Model_Discounts to delete
    /// </summary>
    /// <value>the Model_Discounts to delete</value>
    [DataMember(Name="discountDelete[]", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountDelete[]")]
    public ModelDiscounts DiscountDelete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelInvoiceFactory {\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  InvoicePosSave: ").Append(InvoicePosSave).Append("\n");
      sb.Append("  InvoicePosDelete: ").Append(InvoicePosDelete).Append("\n");
      sb.Append("  DiscountSave: ").Append(DiscountSave).Append("\n");
      sb.Append("  DiscountDelete: ").Append(DiscountDelete).Append("\n");
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
