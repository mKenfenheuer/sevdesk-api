using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// Below are the models which can be used for the functions in Contact/Factory.php. Beware that you need to use them without the underscore at the beginning!
  /// </summary>
  [DataContract]
  public class ModelContactFactory {
    /// <summary>
    /// here you can find useful parameters for your contact requests
    /// </summary>
    /// <value>here you can find useful parameters for your contact requests</value>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public ModelContact Contact { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelContactFactory {\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
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
