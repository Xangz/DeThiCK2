using System;
using System.Collections.Generic;

namespace NguyenDinhSang_241230832.Models;

public partial class TheLoai
{
    public int MaTL{ get; set; }

    public string TenTL { get; set; } = null!;

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
