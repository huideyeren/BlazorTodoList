using Microsoft.AspNetCore.Components;
using BlazorTodoList.Shared;

namespace BlazorTodoList.Client.Shared
{
    public class TodoItemModel : ComponentBase
    {
        [Parameter]
        public Todo Todo { get; set; }
        
        [Parameter]
        public EventCallback<Todo> OnClickDeleteButton { get; set; }
    }
}