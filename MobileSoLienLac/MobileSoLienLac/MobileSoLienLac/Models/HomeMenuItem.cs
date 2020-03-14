using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSoLienLac.Models
{
    public enum MenuItemType
    {
        TrangChu,
        Diem, // Diểm + HK
        ChuyenCan,
        ThoiKhoaBieu,
        ThongTinHS,
        ThongTinGV,
        DoiMatKhau,
        DangXuat
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
