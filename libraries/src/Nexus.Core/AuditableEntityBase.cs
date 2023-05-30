﻿using Nexus.Core.Abstractions.Common;

namespace Nexus.Core;

public abstract class AuditableEntityBase : EntityBase, IAuditable<string>
{
    public string CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime ModifiedOn { get; set; }
}