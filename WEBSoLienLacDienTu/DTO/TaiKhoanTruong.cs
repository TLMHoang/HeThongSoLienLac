using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table("nxtckedu_sa.TaiKhoanTruong")]
    public class TaiKhoanTruong
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [StringLength(500)]
        public string MatKhau { get; set; }

        public byte Loai { get; set; }

        [StringLength(200)]
        public string TenGV { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        public int IDMonHoc { get; set; }

        public int IDLop { get; set; }

        public TaiKhoanTruong()
        {
            ID = -1;
            TaiKhoan = "";
            MatKhau = "";
            Loai = 0;
            TenGV = "";
            SDT = "";
            IDMonHoc = -1;
            IDLop = -1;
        }
        public TaiKhoanTruong(int iD, string taiKhoan, string matKhau, byte loai, string tenGv, string sdt, int idMonHoc, int idLop)
        {
            ID = iD;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            Loai = loai;
            TenGV = tenGv;
            SDT = sdt;
            IDMonHoc = idMonHoc;
            IDLop = idLop;
        }

        public TaiKhoanTruong(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TaiKhoan = dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString();
            Loai = Convert.ToByte(dr["Loai"]);
            TenGV = dr["TenGV"].ToString();
            SDT = dr["SDT"].ToString();
            IDMonHoc = Convert.IsDBNull(dr["IDMonHoc"]) ? -1 : Convert.ToInt32(dr["IDMonHoc"]);
            IDLop = Convert.IsDBNull(dr["IDLop"]) ? -1 : Convert.ToInt32(dr["IDLop"]);
        }
    }
}
