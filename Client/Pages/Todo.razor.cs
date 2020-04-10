using Microsoft.AspNetCore.Components;
using BlazorTodoList.Shared;
using System.Collections.Generic;

namespace BlazorTodoList.Client.Pages
{
    public class TodoModel : ComponentBase
    {
        public BlazorTodoList.Shared.Todo Item { get; set; } = new BlazorTodoList.Shared.Todo();
        public List<BlazorTodoList.Shared.Todo> TodoList { get; set; }
            = new List<BlazorTodoList.Shared.Todo>();

        public void AddTodo()
        {
            TodoList.Add(Item);
            Item = new BlazorTodoList.Shared.Todo();
        }

        public void DeleteTodo(BlazorTodoList.Shared.Todo item)
        {
            TodoList.Remove(item);
        }
    }
}