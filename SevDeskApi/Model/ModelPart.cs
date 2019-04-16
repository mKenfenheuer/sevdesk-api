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
  public class ModelPart {
    /// <summary>
    /// date the part was created
    /// </summary>
    /// <value>date the part was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the part was last updated
    /// </summary>
    /// <value>date the part was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// name of the part
    /// </summary>
    /// <value>name of the part</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

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
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public ModelCategory Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="stock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stock")]
    public float? Stock { get; set; }

    /// <summary>
    /// unity of the part, references Unity.php
    /// </summary>
    /// <value>unity of the part, references Unity.php</value>
    [DataMember(Name="unity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unity")]
    public ModelUnity Unity { get; set; }

    /// <summary>
    /// price for a partner. Can be added via the options in the inventory where the part is displayed
    /// </summary>
    /// <value>price for a partner. Can be added via the options in the inventory where the part is displayed</value>
    [DataMember(Name="pricePartner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricePartner")]
    public float? PricePartner { get; set; }

    /// <summary>
    /// price for a customer. Can be added via the options in the inventory where the part is displayed
    /// </summary>
    /// <value>price for a customer. Can be added via the options in the inventory where the part is displayed</value>
    [DataMember(Name="priceCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceCustomer")]
    public float? PriceCustomer { get; set; }

    /// <summary>
    /// price of the part
    /// </summary>
    /// <value>price of the part</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    /// <summary>
    /// a second unity which can be added to the part
    /// </summary>
    /// <value>a second unity which can be added to the part</value>
    [DataMember(Name="secondUnity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondUnity")]
    public ModelUnity SecondUnity { get; set; }

    /// <summary>
    /// factor for the second unity resulting in a new sumNet for the secondUnity
    /// </summary>
    /// <value>factor for the second unity resulting in a new sumNet for the secondUnity</value>
    [DataMember(Name="secondUnityFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondUnityFactor")]
    public float? SecondUnityFactor { get; set; }

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
    [DataMember(Name="pricePurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pricePurchase")]
    public float? PricePurchase { get; set; }

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
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// characteristics of the part
    /// </summary>
    /// <value>characteristics of the part</value>
    [DataMember(Name="characteristics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characteristics")]
    public string Characteristics { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public ModelPart Origin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="characteristicsString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characteristicsString")]
    public string CharacteristicsString { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="internalComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalComment")]
    public string InternalComment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public ModelEntryType EntryType { get; set; }

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
    [DataMember(Name="priceNet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceNet")]
    public float? PriceNet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="priceGross", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceGross")]
    public float? PriceGross { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPart {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Stock: ").Append(Stock).Append("\n");
      sb.Append("  Unity: ").Append(Unity).Append("\n");
      sb.Append("  PricePartner: ").Append(PricePartner).Append("\n");
      sb.Append("  PriceCustomer: ").Append(PriceCustomer).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  SecondUnity: ").Append(SecondUnity).Append("\n");
      sb.Append("  SecondUnityFactor: ").Append(SecondUnityFactor).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  PricePurchase: ").Append(PricePurchase).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  CharacteristicsString: ").Append(CharacteristicsString).Append("\n");
      sb.Append("  InternalComment: ").Append(InternalComment).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  AccountingType: ").Append(AccountingType).Append("\n");
      sb.Append("  PriceNet: ").Append(PriceNet).Append("\n");
      sb.Append("  PriceGross: ").Append(PriceGross).Append("\n");
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
