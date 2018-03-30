namespace GrpcExample.Services {
    public partial class Todo {
        public string FormattedString => $"ID: {this.Id} | Done: {this.Done} | Title: {this.Text}";
    }
}