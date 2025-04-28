using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class Workflow
{
    public int WorkflowId { get; set; }

    public int? PortalId { get; set; }

    public string WorkflowName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<WorkflowState> WorkflowStates { get; set; } = new List<WorkflowState>();
}
