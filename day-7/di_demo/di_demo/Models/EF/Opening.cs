using System;
using System.Collections.Generic;

namespace di_demo.Models.EF;

public partial class Opening
{
    public int PositionId { get; set; }

    public int? TotalPositions { get; set; }

    public string? Designation { get; set; }

    public string? JobTitle { get; set; }

    public bool? IsPositionOpen { get; set; }

    public int? PositionDept { get; set; }

    public virtual DeptInfo? PositionDeptNavigation { get; set; }
}
