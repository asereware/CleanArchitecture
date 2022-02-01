using MetisBpm.Domain.Common;

namespace MetisBpm.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
