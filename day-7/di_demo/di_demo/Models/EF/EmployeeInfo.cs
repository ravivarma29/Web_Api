using System;
using System.Collections.Generic;

namespace di_demo.Models.EF;

public partial class EmployeeInfo
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }

    public int? DepartmentNo { get; set; }
}
