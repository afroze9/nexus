﻿using ProjectManagement.ProjectAPI.Abstractions;
using ProjectManagement.ProjectAPI.Common;
using ProjectManagement.ProjectAPI.Domain.Entities.Events;

namespace ProjectManagement.ProjectAPI.Domain.Entities;

public class TodoItem : EntityBase, IAggregateRoot, IAuditable<string>
{
    required public string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public string? AssignedToId { get; set; }

    public bool IsCompleted { get; private set; }

    public string CreatedBy { get; set; } = string.Empty;

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; } = string.Empty;

    public DateTime ModifiedOn { get; set; }

    public void MarkComplete()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            ItemCompletedEvent @event = new (this);
            RegisterDomainEvent(@event);
        }
    }

    public void AssignTodoItem(string assignedToId)
    {
        AssignedToId = assignedToId;
        TodoItemAssignedEvent @event = new (this, assignedToId);
        RegisterDomainEvent(@event);
    }
}