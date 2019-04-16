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
  public class ModelInvoicePos {
    /// <summary>
    /// creation date of the invoice position
    /// </summary>
    /// <value>creation date of the invoice position</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the invoice position was last updated
    /// </summary>
    /// <value>date the invoice position was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// the Model_Invoice the invoice position belongs to
    /// </summary>
    /// <value>the Model_Invoice the invoice position belongs to</value>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public ModelInvoice Invoice { get; set; }

    /// <summary>
    /// the product/part which belongs to the invoice position
    /// </summary>
    /// <value>the product/part which belongs to the invoice position</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public ModelPart Part { get; set; }

    /// <summary>
    /// the quantity of the product/part
    /// </summary>
    /// <value>the quantity of the product/part</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public float? Quantity { get; set; }

    /// <summary>
    /// the price of the product/part
    /// </summary>
    /// <value>the price of the product/part</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// the name of the product/part
    /// </summary>
    /// <value>the name of the product/part</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="unity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unity")]
    public ModelUnity Unity { get; set; }

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
    [DataMember(Name="positionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionNumber")]
    public int? PositionNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// does not get filled, discount is handled in the discount_model
    /// </summary>
    /// <value>does not get filled, discount is handled in the discount_model</value>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public float? Discount { get; set; }

    /// <summary>
    /// tax rate in percent
    /// </summary>
    /// <value>tax rate in percent</value>
    [DataMember(Name="taxRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxRate")]
    public float? TaxRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="temporary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temporary")]
    public bool? Temporary { get; set; }

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
    [DataMember(Name="sumGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGross")]
    public float? SumGross { get; set; }

    /// <summary>
    /// does not get filled, sumDiscount is handled in the discount_model
    /// </summary>
    /// <value>does not get filled, sumDiscount is handled in the discount_model</value>
    [DataMember(Name="sumDiscount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumDiscount")]
    public float? SumDiscount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumTax")]
    public float? SumTax { get; set; }

    /// <summary>
    /// equals sumNet
    /// </summary>
    /// <value>equals sumNet</value>
    [DataMember(Name="sumNetAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumNetAccounting")]
    public float? SumNetAccounting { get; set; }

    /// <summary>
    /// equals sumTax
    /// </summary>
    /// <value>equals sumTax</value>
    [DataMember(Name="sumTaxAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumTaxAccounting")]
    public float? SumTaxAccounting { get; set; }

    /// <summary>
    /// equals sumGross
    /// </summary>
    /// <value>equals sumGross</value>
    [DataMember(Name="sumGrossAccounting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumGrossAccounting")]
    public float? SumGrossAccounting { get; set; }

    /// <summary>
    /// net price of the product/part (one)
    /// </summary>
    /// <value>net price of the product/part (one)</value>
    [DataMember(Name="priceNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceNet")]
    public float? PriceNet { get; set; }

    /// <summary>
    /// gross price of the product/part (one)
    /// </summary>
    /// <value>gross price of the product/part (one)</value>
    [DataMember(Name="priceGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceGross")]
    public float? PriceGross { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="priceTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceTax")]
    public float? PriceTax { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelInvoicePos {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  Part: ").Append(Part).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Unity: ").Append(Unity).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  PositionNumber: ").Append(PositionNumber).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  SumDiscount: ").Append(SumDiscount).Append("\n");
      sb.Append("  SumTax: ").Append(SumTax).Append("\n");
      sb.Append("  SumNetAccounting: ").Append(SumNetAccounting).Append("\n");
      sb.Append("  SumTaxAccounting: ").Append(SumTaxAccounting).Append("\n");
      sb.Append("  SumGrossAccounting: ").Append(SumGrossAccounting).Append("\n");
      sb.Append("  PriceNet: ").Append(PriceNet).Append("\n");
      sb.Append("  PriceGross: ").Append(PriceGross).Append("\n");
      sb.Append("  PriceTax: ").Append(PriceTax).Append("\n");
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
