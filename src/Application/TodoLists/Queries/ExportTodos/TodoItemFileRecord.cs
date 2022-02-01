using MetisBpm.Application.Common.Mappings;
using MetisBpm.Domain.Entities;

namespace MetisBpm.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
