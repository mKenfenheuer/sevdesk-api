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
  public class ModelSevToken {
    /// <summary>
    /// date the sevToken was created
    /// </summary>
    /// <value>date the sevToken was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the sevToken was last updated
    /// </summary>
    /// <value>date the sevToken was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// SevUser to whom the sevToken belongs
    /// </summary>
    /// <value>SevUser to whom the sevToken belongs</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public Object User { get; set; }

    /// <summary>
    /// token of the sevUser
    /// </summary>
    /// <value>token of the sevUser</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// expiration date of the token
    /// </summary>
    /// <value>expiration date of the token</value>
    [DataMember(Name="expire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expire")]
    public DateTime? Expire { get; set; }

    /// <summary>
    /// Defines if the token is active
    /// </summary>
    /// <value>Defines if the token is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// sevClient is the unique id every customer has and is used in nearly all operations
    /// </summary>
    /// <value>sevClient is the unique id every customer has and is used in nearly all operations</value>
    [DataMember(Name="sevClient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sevClient")]
    public Object SevClient { get; set; }

    /// <summary>
    /// Ip address of the user
    /// </summary>
    /// <value>Ip address of the user</value>
    [DataMember(Name="ipAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipAddress")]
    public string IpAddress { get; set; }

    /// <summary>
    /// Information about the users system
    /// </summary>
    /// <value>Information about the users system</value>
    [DataMember(Name="userAgent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userAgent")]
    public string UserAgent { get; set; }

    /// <summary>
    /// Type of the token
    /// </summary>
    /// <value>Type of the token</value>
    [DataMember(Name="tokenType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenType")]
    public string TokenType { get; set; }

    /// <summary>
    /// Confirmation token
    /// </summary>
    /// <value>Confirmation token</value>
    [DataMember(Name="confirmationToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirmationToken")]
    public string ConfirmationToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelSevToken {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  Expire: ").Append(Expire).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
      sb.Append("  TokenType: ").Append(TokenType).Append("\n");
      sb.Append("  ConfirmationToken: ").Append(ConfirmationToken).Append("\n");
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
