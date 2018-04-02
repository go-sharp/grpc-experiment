using System;
using GrpcExample.Services;

namespace GrpcExample.Client
{
    public class CmdClient
    {
        public TodoService.TodoServiceClient Client { get; private set; }

        public CmdClient(TodoService.TodoServiceClient client)
        {
            this.Client = client ?? throw new ArgumentNullException(nameof(client), "must not be null");
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine(@"
TodoService Commandline Interface:

[1] add todo
[2] update todo
[3] delete todo
[4] get todo
[5] list todos
[q] exit
                ");
                Console.Write("Enter selection: ");
                var line = Console.ReadLine().Trim();
                Console.WriteLine();

                switch (line)
                {
                    case "1":
                        this.AddTodoMenu();
                        break;
                    case "2":
                        this.UpdateTodoMenu();
                        break;
                    case "3":
                        this.DeleteTodoMenu();
                        break;
                    case "4":
                        this.GetTodoMenu();
                        break;
                    case "5":
                        this.ListTodos();
                        break;
                    case "q":
                        return;

                }
            }
        }

        private void UpdateTodoMenu()
        {
            try
            {
                var todo = this.GetTodo();

                Console.Write($"Title [{todo?.Text}]: ");
                var line = Console.ReadLine().Trim();
                todo.Text = line.Length == 0 ? todo.Text : line;

                Console.Write($"Done [{todo?.Done}]: ");

                var done = Console.ReadLine().Trim();
                bool isDone;
                bool.TryParse(done, out isDone);
                todo.Done = isDone;

                this.Client.Update(todo);
                this.Write("success", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                this.LogError(e);
            }
        }

        private void DeleteTodoMenu()
        {
            try
            {
                var todo = this.GetTodo();
                var response = this.Client.Delete(new DeleteRequest { Id = todo.Id });
                this.Write("success\n", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                this.LogError(e);
            }
        }

        private void GetTodoMenu()
        {
            try
            {
                var todo = this.GetTodo();
                Console.WriteLine(todo.FormattedString);
            }
            catch (ArgumentException) { }
            catch (Exception e)
            {
                this.LogError(e);
            }
        }

        private void ListTodos()
        {
            try
            {
                var todos = this.Client.List(new Empty());

                foreach (var todo in todos.Todos_)
                {
                    Console.WriteLine(todo.FormattedString);
                }
            }
            catch (ArgumentException) { }
            catch (Exception e)
            {
                this.LogError(e);
            }
        }

        private void AddTodoMenu()
        {
            try
            {
                var todo = new Todo();
                Console.Write("Title: ");
                todo.Text = Console.ReadLine().Trim();
                Console.Write("\nDone (false|true): ");

                var done = Console.ReadLine().Trim();
                bool isDone;
                bool.TryParse(done, out isDone);
                todo.Done = isDone;

                this.Client.Create(todo);
                this.Write("success", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                this.LogError(e);
            }
        }

        private void LogError(Exception e)
        {
            this.Write($"{e.Message}\n", ConsoleColor.Red);
        }

        private void Write(string msg, ConsoleColor color)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ForegroundColor = original;
        }


        private Todo GetTodo()
        {
            Console.Write("Enter ID: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                this.Write("error: ", ConsoleColor.Red);
                Console.WriteLine("no valid number entered");
                throw new ArgumentException("invalid id");
            }

            Console.WriteLine("");
            return this.Client.Get(new TodoRequest() { Id = id });
        }
    }
}