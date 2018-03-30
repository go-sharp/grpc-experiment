// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protobuf/todo.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcExample.Services {

  /// <summary>Holder for reflection information generated from protobuf/todo.proto</summary>
  public static partial class TodoReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/todo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TodoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNwcm90b2J1Zi90b2RvLnByb3RvEhRHcnBjRXhhbXBsZS5TZXJ2aWNlcyIG",
            "CgRWb2lkIhwKDkdldFRvZG9SZXF1ZXN0EgoKAmlkGAEgASgFIi4KBFRvZG8S",
            "CgoCaWQYASABKAUSDAoEdGV4dBgCIAEoCRIMCgRkb25lGAMgASgIIjIKBVRv",
            "ZG9zEikKBXRvZG9zGAEgAygLMhouR3JwY0V4YW1wbGUuU2VydmljZXMuVG9k",
            "byIVCgVFcnJvchIMCgR0ZXh0GAEgASgJIqIBCgxUb2RvUmVzcG9uc2USLAoG",
            "c3RhdHVzGAEgASgOMhwuR3JwY0V4YW1wbGUuU2VydmljZXMuU3RhdHVzEioK",
            "BHRvZG8YAiABKAsyGi5HcnBjRXhhbXBsZS5TZXJ2aWNlcy5Ub2RvSAASLAoF",
            "ZXJyb3IYAyABKAsyGy5HcnBjRXhhbXBsZS5TZXJ2aWNlcy5FcnJvckgAQgoK",
            "CHJlc3BvbnNlIhsKDURlbGV0ZVJlcXVlc3QSCgoCaWQYASABKAUiPgoORGVs",
            "ZXRlUmVzcG9uc2USLAoGc3RhdHVzGAEgASgOMhwuR3JwY0V4YW1wbGUuU2Vy",
            "dmljZXMuU3RhdHVzKhwKBlN0YXR1cxIGCgJPSxAAEgoKBkZBSUxFRBABMpID",
            "CgtUb2RvU2VydmljZRJKCgZDcmVhdGUSGi5HcnBjRXhhbXBsZS5TZXJ2aWNl",
            "cy5Ub2RvGiIuR3JwY0V4YW1wbGUuU2VydmljZXMuVG9kb1Jlc3BvbnNlIgAS",
            "SgoGVXBkYXRlEhouR3JwY0V4YW1wbGUuU2VydmljZXMuVG9kbxoiLkdycGNF",
            "eGFtcGxlLlNlcnZpY2VzLlRvZG9SZXNwb25zZSIAElEKA0dldBIkLkdycGNF",
            "eGFtcGxlLlNlcnZpY2VzLkdldFRvZG9SZXF1ZXN0GiIuR3JwY0V4YW1wbGUu",
            "U2VydmljZXMuVG9kb1Jlc3BvbnNlIgASVQoGRGVsZXRlEiMuR3JwY0V4YW1w",
            "bGUuU2VydmljZXMuRGVsZXRlUmVxdWVzdBokLkdycGNFeGFtcGxlLlNlcnZp",
            "Y2VzLkRlbGV0ZVJlc3BvbnNlIgASQQoETGlzdBIaLkdycGNFeGFtcGxlLlNl",
            "cnZpY2VzLlZvaWQaGy5HcnBjRXhhbXBsZS5TZXJ2aWNlcy5Ub2RvcyIAYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GrpcExample.Services.Status), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.Void), global::GrpcExample.Services.Void.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.GetTodoRequest), global::GrpcExample.Services.GetTodoRequest.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.Todo), global::GrpcExample.Services.Todo.Parser, new[]{ "Id", "Text", "Done" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.Todos), global::GrpcExample.Services.Todos.Parser, new[]{ "Todos_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.Error), global::GrpcExample.Services.Error.Parser, new[]{ "Text" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.TodoResponse), global::GrpcExample.Services.TodoResponse.Parser, new[]{ "Status", "Todo", "Error" }, new[]{ "Response" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.DeleteRequest), global::GrpcExample.Services.DeleteRequest.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcExample.Services.DeleteResponse), global::GrpcExample.Services.DeleteResponse.Parser, new[]{ "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Status of the service operation
  /// </summary>
  public enum Status {
    /// <summary>
    /// First Enum must be 0
    /// </summary>
    [pbr::OriginalName("OK")] Ok = 0,
    [pbr::OriginalName("FAILED")] Failed = 1,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Every Service needs a message and this is an empty message
  /// </summary>
  public sealed partial class Void : pb::IMessage<Void> {
    private static readonly pb::MessageParser<Void> _parser = new pb::MessageParser<Void>(() => new Void());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Void> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void(Void other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Void Clone() {
      return new Void(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Void);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Void other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Void other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class GetTodoRequest : pb::IMessage<GetTodoRequest> {
    private static readonly pb::MessageParser<GetTodoRequest> _parser = new pb::MessageParser<GetTodoRequest>(() => new GetTodoRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTodoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTodoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTodoRequest(GetTodoRequest other) : this() {
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTodoRequest Clone() {
      return new GetTodoRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTodoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTodoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTodoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Todo : pb::IMessage<Todo> {
    private static readonly pb::MessageParser<Todo> _parser = new pb::MessageParser<Todo>(() => new Todo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Todo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todo(Todo other) : this() {
      id_ = other.id_;
      text_ = other.text_;
      done_ = other.done_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todo Clone() {
      return new Todo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "done" field.</summary>
    public const int DoneFieldNumber = 3;
    private bool done_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Done {
      get { return done_; }
      set {
        done_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Todo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Todo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Text != other.Text) return false;
      if (Done != other.Done) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (Done != false) hash ^= Done.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (Done != false) {
        output.WriteRawTag(24);
        output.WriteBool(Done);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (Done != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Todo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.Done != false) {
        Done = other.Done;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
          case 24: {
            Done = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Todos : pb::IMessage<Todos> {
    private static readonly pb::MessageParser<Todos> _parser = new pb::MessageParser<Todos>(() => new Todos());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Todos> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todos() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todos(Todos other) : this() {
      todos_ = other.todos_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Todos Clone() {
      return new Todos(this);
    }

    /// <summary>Field number for the "todos" field.</summary>
    public const int Todos_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcExample.Services.Todo> _repeated_todos_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcExample.Services.Todo.Parser);
    private readonly pbc::RepeatedField<global::GrpcExample.Services.Todo> todos_ = new pbc::RepeatedField<global::GrpcExample.Services.Todo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcExample.Services.Todo> Todos_ {
      get { return todos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Todos);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Todos other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!todos_.Equals(other.todos_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= todos_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      todos_.WriteTo(output, _repeated_todos_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += todos_.CalculateSize(_repeated_todos_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Todos other) {
      if (other == null) {
        return;
      }
      todos_.Add(other.todos_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            todos_.AddEntriesFrom(input, _repeated_todos_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Error : pb::IMessage<Error> {
    private static readonly pb::MessageParser<Error> _parser = new pb::MessageParser<Error>(() => new Error());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Error> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error(Error other) : this() {
      text_ = other.text_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error Clone() {
      return new Error(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Error);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Error other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Error other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TodoResponse : pb::IMessage<TodoResponse> {
    private static readonly pb::MessageParser<TodoResponse> _parser = new pb::MessageParser<TodoResponse>(() => new TodoResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TodoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TodoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TodoResponse(TodoResponse other) : this() {
      status_ = other.status_;
      switch (other.ResponseCase) {
        case ResponseOneofCase.Todo:
          Todo = other.Todo.Clone();
          break;
        case ResponseOneofCase.Error:
          Error = other.Error.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TodoResponse Clone() {
      return new TodoResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::GrpcExample.Services.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcExample.Services.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "todo" field.</summary>
    public const int TodoFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcExample.Services.Todo Todo {
      get { return responseCase_ == ResponseOneofCase.Todo ? (global::GrpcExample.Services.Todo) response_ : null; }
      set {
        response_ = value;
        responseCase_ = value == null ? ResponseOneofCase.None : ResponseOneofCase.Todo;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcExample.Services.Error Error {
      get { return responseCase_ == ResponseOneofCase.Error ? (global::GrpcExample.Services.Error) response_ : null; }
      set {
        response_ = value;
        responseCase_ = value == null ? ResponseOneofCase.None : ResponseOneofCase.Error;
      }
    }

    private object response_;
    /// <summary>Enum of possible cases for the "response" oneof.</summary>
    public enum ResponseOneofCase {
      None = 0,
      Todo = 2,
      Error = 3,
    }
    private ResponseOneofCase responseCase_ = ResponseOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResponseOneofCase ResponseCase {
      get { return responseCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearResponse() {
      responseCase_ = ResponseOneofCase.None;
      response_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TodoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TodoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Todo, other.Todo)) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (ResponseCase != other.ResponseCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (responseCase_ == ResponseOneofCase.Todo) hash ^= Todo.GetHashCode();
      if (responseCase_ == ResponseOneofCase.Error) hash ^= Error.GetHashCode();
      hash ^= (int) responseCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (responseCase_ == ResponseOneofCase.Todo) {
        output.WriteRawTag(18);
        output.WriteMessage(Todo);
      }
      if (responseCase_ == ResponseOneofCase.Error) {
        output.WriteRawTag(26);
        output.WriteMessage(Error);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (responseCase_ == ResponseOneofCase.Todo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Todo);
      }
      if (responseCase_ == ResponseOneofCase.Error) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TodoResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      switch (other.ResponseCase) {
        case ResponseOneofCase.Todo:
          if (Todo == null) {
            Todo = new global::GrpcExample.Services.Todo();
          }
          Todo.MergeFrom(other.Todo);
          break;
        case ResponseOneofCase.Error:
          if (Error == null) {
            Error = new global::GrpcExample.Services.Error();
          }
          Error.MergeFrom(other.Error);
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::GrpcExample.Services.Status) input.ReadEnum();
            break;
          }
          case 18: {
            global::GrpcExample.Services.Todo subBuilder = new global::GrpcExample.Services.Todo();
            if (responseCase_ == ResponseOneofCase.Todo) {
              subBuilder.MergeFrom(Todo);
            }
            input.ReadMessage(subBuilder);
            Todo = subBuilder;
            break;
          }
          case 26: {
            global::GrpcExample.Services.Error subBuilder = new global::GrpcExample.Services.Error();
            if (responseCase_ == ResponseOneofCase.Error) {
              subBuilder.MergeFrom(Error);
            }
            input.ReadMessage(subBuilder);
            Error = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class DeleteRequest : pb::IMessage<DeleteRequest> {
    private static readonly pb::MessageParser<DeleteRequest> _parser = new pb::MessageParser<DeleteRequest>(() => new DeleteRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteRequest(DeleteRequest other) : this() {
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteRequest Clone() {
      return new DeleteRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DeleteResponse : pb::IMessage<DeleteResponse> {
    private static readonly pb::MessageParser<DeleteResponse> _parser = new pb::MessageParser<DeleteResponse>(() => new DeleteResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcExample.Services.TodoReflection.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteResponse(DeleteResponse other) : this() {
      status_ = other.status_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteResponse Clone() {
      return new DeleteResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::GrpcExample.Services.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcExample.Services.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::GrpcExample.Services.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code