using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class MonThi
{
    public string MaMonThi { get; set; } = null!;

    public string? TenMonThi { get; set; }

    public int? SoTinChi { get; set; }

    public int? SoLuongCauHoi { get; set; }

    public virtual ICollection<CauHoi> CauHois { get; set; } = new List<CauHoi>();

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
}
