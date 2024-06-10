namespace BrainBox.Domain.Primitives;

using MediatR;

public record DomainEvent(Guid Id): INotification;