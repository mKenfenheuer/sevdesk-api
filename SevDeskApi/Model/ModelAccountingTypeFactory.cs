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
  public class ModelAccountingTypeFactory {
    /// <summary>
    /// here you can find useful parameters for your accounting type request
    /// </summary>
    /// <value>here you can find useful parameters for your accounting type request</value>
    [DataMember(Name="AccountingType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountingType")]
    public ModelAccountingType AccountingType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelAccountingTypeFactory {\n");
      sb.Append("  AccountingType: ").Append(AccountingType).Append("\n");
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
