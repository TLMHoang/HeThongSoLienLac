using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        public int ID { get; set; } 
        public string TenMon { get; set; }
        public byte LoaiDiem { get; set; }

        public MonHoc() { ID = -1; TenMon = ""; LoaiDiem = 1; }

        public MonHoc(int iD, string tenMon, byte loaiDiem)
        {
            ID = iD;
            TenMon = tenMon;
            LoaiDiem = loaiDiem;
        }

        public MonHoc(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            TenMon = dr["MonHoc"].ToString();
            LoaiDiem = Convert.ToByte(dr["LoaiDiem"]);
        }
    }
}
