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
  public class ModelTask {
    /// <summary>
    /// the date the task was created
    /// </summary>
    /// <value>the date the task was created</value>
    [DataMember(Name="create", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create")]
    public DateTime? Create { get; set; }

    /// <summary>
    /// date the task was last updated
    /// </summary>
    /// <value>date the task was last updated</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public DateTime? Update { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// the sevDesk user who is assigned to the task
    /// </summary>
    /// <value>the sevDesk user who is assigned to the task</value>
    [DataMember(Name="assigned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigned")]
    public ModelSevUser Assigned { get; set; }

    /// <summary>
    /// can be a contact, invoice, etc to which the task refers to
    /// </summary>
    /// <value>can be a contact, invoice, etc to which the task refers to</value>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public Object Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="deadline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deadline")]
    public DateTime? Deadline { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// category of the created task
    /// </summary>
    /// <value>category of the created task</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public ModelCategory Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="done", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "done")]
    public DateTime? Done { get; set; }

    /// <summary>
    /// the SevUser who created the task
    /// </summary>
    /// <value>the SevUser who created the task</value>
    [DataMember(Name="createUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createUser")]
    public ModelSevUser CreateUser { get; set; }

    /// <summary>
    /// the SevUser who completed the task
    /// </summary>
    /// <value>the SevUser who completed the task</value>
    [DataMember(Name="doneUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "doneUser")]
    public ModelSevUser DoneUser { get; set; }

    /// <summary>
    /// notice the creator when the task is finished
    /// </summary>
    /// <value>notice the creator when the task is finished</value>
    [DataMember(Name="noticeCreator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noticeCreator")]
    public bool? NoticeCreator { get; set; }

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
    [DataMember(Name="begin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "begin")]
    public DateTime? Begin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelTask {\n");
      sb.Append("  Create: ").Append(Create).Append("\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Assigned: ").Append(Assigned).Append("\n");
      sb.Append("  Object: ").Append(Object).Append("\n");
      sb.Append("  Deadline: ").Append(Deadline).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Done: ").Append(Done).Append("\n");
      sb.Append("  CreateUser: ").Append(CreateUser).Append("\n");
      sb.Append("  DoneUser: ").Append(DoneUser).Append("\n");
      sb.Append("  NoticeCreator: ").Append(NoticeCreator).Append("\n");
      sb.Append("  SevClient: ").Append(SevClient).Append("\n");
      sb.Append("  Begin: ").Append(Begin).Append("\n");
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
