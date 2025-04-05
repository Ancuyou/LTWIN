using System;
using System.Collections.Generic;

namespace SQLProgramming.Models;

public partial class TblLop
{
    public string Malop { get; set; } = null!;

    public string? Tenlop { get; set; }

    public string? Nganhhoc { get; set; }

    public int? Slsv { get; set; }

    public int? Namvaohoc { get; set; }

    public virtual ICollection<TblSinhVien> TblSinhViens { get; set; } = new List<TblSinhVien>();
}
