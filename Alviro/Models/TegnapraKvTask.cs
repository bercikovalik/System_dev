using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class TegnapraKvTask
{
    public int TaskId { get; set; }

    public string TaskName { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public bool IsComplete { get; set; }

    public int ModuleId { get; set; }

    public int UserId { get; set; }
}
