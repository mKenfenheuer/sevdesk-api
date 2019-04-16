using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// The inventory part log contains all part bookings (acquisition/dispatch)
  /// </summary>
  [DataContract]
  public class ModelInventoryPartLog {
    /// <summary>
    /// creation date of the inventory part log
    /// </summary>
    /// <value>creation date of the inventory part log</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="postingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postingDate")]
    public DateTime? PostingDate { get; set; }

    /// <summary>
    /// part which is involved in the part booking which is logged
    /// </summary>
    /// <value>part which is involved in the part booking which is logged</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public Object Part { get; set; }

    /// <summary>
    /// supplier which is involved in the part booking which is logged
    /// </summary>
    /// <value>supplier which is involved in the part booking which is logged</value>
    [DataMember(Name="supplier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier")]
    public Object Supplier { get; set; }

    /// <summary>
    /// amount booked which is logged
    /// </summary>
    /// <value>amount booked which is logged</value>
    [DataMember(Name="ammount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammount")]
    public float? Ammount { get; set; }

    /// <summary>
    /// description of the booking which is logged
    /// </summary>
    /// <value>description of the booking which is logged</value>
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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelInventoryPartLog {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  PostingDate: ").Append(PostingDate).Append("\n");
      sb.Append("  Part: ").Append(Part).Append("\n");
      sb.Append("  Supplier: ").Append(Supplier).Append("\n");
      sb.Append("  Ammount: ").Append(Ammount).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
