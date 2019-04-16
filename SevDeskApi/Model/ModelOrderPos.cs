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
  public class ModelOrderPos {
    /// <summary>
    /// creation date of the order position
    /// </summary>
    /// <value>creation date of the order position</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the order position was last updated
    /// </summary>
    /// <value>date the order position was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// Model_Order the position belongs to
    /// </summary>
    /// <value>Model_Order the position belongs to</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public ModelOrder Order { get; set; }

    /// <summary>
    /// The Model_Part which is used in Model_OrderPos
    /// </summary>
    /// <value>The Model_Part which is used in Model_OrderPos</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public ModelPart Part { get; set; }

    /// <summary>
    /// quantity of the Model_Part
    /// </summary>
    /// <value>quantity of the Model_Part</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public float? Quantity { get; set; }

    /// <summary>
    /// price of the Model_Part
    /// </summary>
    /// <value>price of the Model_Part</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public float? Discount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="optional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optional")]
    public bool? Optional { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="optionalChargeable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optionalChargeable")]
    public bool? OptionalChargeable { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="sumDiscount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sumDiscount")]
    public float? SumDiscount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelOrderPos {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
      sb.Append("  Optional: ").Append(Optional).Append("\n");
      sb.Append("  OptionalChargeable: ").Append(OptionalChargeable).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  SumNet: ").Append(SumNet).Append("\n");
      sb.Append("  SumGross: ").Append(SumGross).Append("\n");
      sb.Append("  SumDiscount: ").Append(SumDiscount).Append("\n");
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
