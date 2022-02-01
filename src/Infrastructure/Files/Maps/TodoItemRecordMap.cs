using System.Globalization;
using MetisBpm.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace MetisBpm.Infraestructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
