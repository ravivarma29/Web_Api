﻿using System;
using System.Collections.Generic;

namespace Employe.Models.EF;

public partial class EmpDetalilsView
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }

    public int? DepartmentNo { get; set; }

    public int DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? DeptCity { get; set; }
}
