using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

public class Project
{
    [Todo("Implement login logic", "Alice", "HIGH")]
    [Todo("Improve security", "Bob", "MEDIUM")]
    public void Login() { }

    [Todo("Optimize database queries", "Charlie", "HIGH")]
    public void FetchData() { }

    [Todo("Add logging mechanism", "David")]
    public void ProcessData() { }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Project);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (MethodInfo method in methods)
        {
            var todos = method.GetCustomAttributes<TodoAttribute>();
            foreach (var todo in todos)
            {
                Console.WriteLine($"Method: {method.Name}, Task: {todo.Task}, AssignedTo: {todo.AssignedTo}, Priority: {todo.Priority}");
            }
        }
    }
}
