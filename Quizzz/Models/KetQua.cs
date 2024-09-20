using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class KetQua
{
    public int MaKetQua { get; set; }

    public int? MaSinhVien { get; set; }

    public string? MaMonThi { get; set; }

    public int? MaCaThi { get; set; }

    public double? Diem { get; set; }

    public virtual CaThi? MaCaThiNavigation { get; set; }

    public virtual MonThi? MaMonThiNavigation { get; set; }

    public virtual SinhVien? MaSinhVienNavigation { get; set; }
}
