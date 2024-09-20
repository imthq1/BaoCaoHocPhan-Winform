using System;
using System.Collections.Generic;

namespace Quizzz.Models;

public partial class Admin
{
    public int MaAdmin { get; set; }

    public string? HoTen { get; set; }

    public string? TenDangNhap { get; set; }

    public string? Password { get; set; }
}
