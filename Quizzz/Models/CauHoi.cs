using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class CauHoi
{
    public int MaCauHoi { get; set; }

    public string? NoiDung { get; set; }

    public string? DapAn { get; set; }

    public string? TenCauHoi { get; set; }

    public int? SoLuongCauHoi { get; set; }

    public string? MaMonThi { get; set; }

    public virtual MonThi? MaMonThiNavigation { get; set; }
}
