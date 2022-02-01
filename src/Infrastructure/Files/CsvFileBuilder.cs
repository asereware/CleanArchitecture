using System.Globalization;
using MetisBpm.Application.Common.Interfaces;
using MetisBpm.Application.TodoLists.Queries.ExportTodos;
using MetisBpm.Infraestructure.Files.Maps;
using CsvHelper;

namespace MetisBpm.Infraestructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
