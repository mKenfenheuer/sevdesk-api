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
  public class ModelDocument {
    /// <summary>
    /// date the document was created
    /// </summary>
    /// <value>date the document was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the document was last updated
    /// </summary>
    /// <value>date the document was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="documentNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentNumber")]
    public string DocumentNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="baseObject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseObject")]
    public DateTime? BaseObject { get; set; }

    /// <summary>
    /// SevUser who created the document
    /// </summary>
    /// <value>SevUser who created the document</value>
    [DataMember(Name="createUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createUser")]
    public ModelSevUser CreateUser { get; set; }

    /// <summary>
    /// SevUser who last updated the document
    /// </summary>
    /// <value>SevUser who last updated the document</value>
    [DataMember(Name="updateUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateUser")]
    public ModelSevUser UpdateUser { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="objectAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectAction")]
    public Object ObjectAction { get; set; }

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
    [DataMember(Name="folder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folder")]
    public ModelDocumentFolder Folder { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="extension", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension")]
    public string Extension { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="filesize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filesize")]
    public int? Filesize { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelDocument {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
      sb.Append("  BaseObject: ").Append(BaseObject).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  UpdateUser: ").Append(UpdateUser).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ObjectAction: ").Append(ObjectAction).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Folder: ").Append(Folder).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Extension: ").Append(Extension).Append("\n");
      sb.Append("  Filesize: ").Append(Filesize).Append("\n");
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
