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
    [Table("nxtckedu_sa.TaiKhoanPH")]
    public class TaiKhoanPH
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [StringLength(500)]
        public string MatKhau { get; set; }

        [StringLength(150)]
        public string TenMe { get; set; }

        [StringLength(12)]
        public string SDTMe { get; set; }

        [StringLength(150)]
        public string TenBo { get; set; }

        [StringLength(12)]
        public string SDTBo { get; set; }

        public TaiKhoanPH()
        {
            ID = -1;
            TaiKhoan = "";
            MatKhau = "";
            TenBo = "";
            TenMe = "";
            SDTBo = "";
            SDTMe = "";
        }
        public TaiKhoanPH(int iD, string taiKhoan, string matKhau, string tenMe, string sdtMe, string tenBo, string sdtBo)
        {
            ID = iD;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            TenBo = tenBo;
            TenMe = tenMe;
            SDTBo = sdtBo;
            SDTMe = sdtMe;
        }

        public TaiKhoanPH(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TaiKhoan = dr["TaiKhoan"].ToString();
            MatKhau = dr["MatKhau"].ToString();
            TenBo = dr["TenBo"].ToString();
            TenMe = dr["TenMe"].ToString();
            SDTBo = dr["SDTBo"].ToString();
            SDTMe = dr["SDTMe"].ToString();
        }
    }
}
