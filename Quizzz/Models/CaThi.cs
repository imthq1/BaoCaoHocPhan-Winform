using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class CaThi
{
    public int MaCaThi { get; set; }

    public DateTime? ThoiGian { get; set; }

    public int? SoNguoi { get; set; }

    public virtual ICollection<KetQua> KetQuas { get; set; } = new List<KetQua>();
}
