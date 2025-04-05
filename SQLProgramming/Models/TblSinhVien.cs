using System;
using System.Collections.Generic;

namespace SQLProgramming.Models;

public partial class TblSinhVien
{
    public string MaSv { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateOnly? NgaySinh { get; set; }

    public string? Quequan { get; set; }

    public string? SoCccd { get; set; }

    public string? Malop { get; set; }

    public string? SoDt { get; set; }

    public virtual TblLop? MalopNavigation { get; set; }
}
