using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SevDeskApi.Model {

  /// <summary>
  /// Below are the models which can be used for the functions in Document/Factory.php. Beware that you need to use them without the underscore at the beginning!
  /// </summary>
  [DataContract]
  public class ModelDocumentFactory {
    /// <summary>
    /// the Model_Document to create
    /// </summary>
    /// <value>the Model_Document to create</value>
    [DataMember(Name="Model_Document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Model_Document")]
    public ModelDocument ModelDocument { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelDocumentFactory {\n");
      sb.Append("  ModelDocument: ").Append(ModelDocument).Append("\n");
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
