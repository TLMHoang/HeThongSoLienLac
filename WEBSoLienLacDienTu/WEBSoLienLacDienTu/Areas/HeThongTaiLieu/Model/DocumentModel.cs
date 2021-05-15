using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class DocumentModel
    {
        public int ID { get; set; }
        public int IDTeacher { get; set; }
        public DateTime CreateAt { get; set; }
        public int IDKhoi { get; set; }
        public int IDSubject { get; set; }
        public string Path { get; set; }
        public string NameDocument { get; set; }
        public IEnumerable<DocumentModel> DocumentList { get; set; }

        public DocumentModel(int iD, int iDTeacher, DateTime createAt, int iDKhoi, int iDSubject, string path, string nameDocument)
        {
            ID = iD;
            IDTeacher = iDTeacher;
            CreateAt = createAt;
            IDKhoi = iDKhoi;
            IDSubject = iDSubject;
            Path = path;
            NameDocument = nameDocument;
        }
        public DocumentModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDTeacher = Convert.IsDBNull(dr["IDTeacher"]) ? -1 : Convert.ToInt32(dr["IDTeacher"]);
            CreateAt = Convert.ToDateTime(dr["CreateAt"]);
            IDKhoi = Convert.IsDBNull(dr["IDKhoi"]) ? -1 : Convert.ToInt32(dr["IDKhoi"]);
            IDSubject = Convert.IsDBNull(dr["IDSubject"]) ? -1 : Convert.ToInt32(dr["IDSubject"]);
            Path = dr["Path"].ToString();
            NameDocument = dr["NameDocument"].ToString();
        }

        public DocumentModel()
        {
            ID = -1;
            IDTeacher = -1;
            CreateAt = DateTime.Now;
            IDKhoi = -1;
            IDSubject = -1;
            Path = "";
            NameDocument = "";
        }
    }
}