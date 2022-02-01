using MetisBpm.Application.Common.Interfaces;

namespace MetisBpm.Infraestructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
    public DateTime UtcNow => DateTime.UtcNow;
}
