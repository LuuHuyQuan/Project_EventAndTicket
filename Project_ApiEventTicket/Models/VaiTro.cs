using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VaiTro
    {
        public int VaiTroID { get; set; }
        public string TenVaiTro { get; set; } = null!;
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; }
    }
}
