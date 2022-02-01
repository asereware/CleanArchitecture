using MetisBpm.Application.TodoLists.Queries.ExportTodos;

namespace MetisBpm.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
