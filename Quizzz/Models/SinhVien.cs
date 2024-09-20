using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class SinhVien
{
    public int MaSinhVien { get; set; }

    public string? HoTen { get; set; }

    public string? LopHoc { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
}
