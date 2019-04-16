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
  public class ModelPlace {
    /// <summary>
    /// name of the place
    /// </summary>
    /// <value>name of the place</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// longitude of the place
    /// </summary>
    /// <value>longitude of the place</value>
    [DataMember(Name="lon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lon")]
    public float? Lon { get; set; }

    /// <summary>
    /// latitude of the place
    /// </summary>
    /// <value>latitude of the place</value>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public float? Lat { get; set; }

    /// <summary>
    /// zip of the place
    /// </summary>
    /// <value>zip of the place</value>
    [DataMember(Name="zip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// location id of the place
    /// </summary>
    /// <value>location id of the place</value>
    [DataMember(Name="locId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locId")]
    public int? LocId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelPlace {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Lon: ").Append(Lon).Append("\n");
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      sb.Append("  Zip: ").Append(Zip).Append("\n");
      sb.Append("  LocId: ").Append(LocId).Append("\n");
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
