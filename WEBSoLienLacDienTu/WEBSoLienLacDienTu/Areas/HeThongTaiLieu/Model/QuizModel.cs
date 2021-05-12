using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class QuizModel
    {
        public int ID { get; set; }
        public int IDSubject { get; set; }
        public int IDTeacher { get; set; }
        public DateTime CreateAt { get; set; }
        public string NameTopic { get; set; }
        public int IDKhoi { get; set; }

        public QuizModel()
        {
            ID = -1;
            IDSubject = -1;
            IDTeacher = -1;
            CreateAt = DateTime.Now;
            NameTopic = "";
            IDKhoi = -1;
        }
        public QuizModel(int iD, int iDSubject, int iDTeacher, DateTime createAt, string nameTopic, int iDKhoi)
        {
            ID = iD;
            IDSubject = iDSubject;
            IDTeacher = iDTeacher;
            CreateAt = createAt;
            NameTopic = nameTopic;
            IDKhoi = iDKhoi;
        }

        public QuizModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDSubject = Convert.IsDBNull(dr["IDSubject"]) ? -1 : Convert.ToInt32(dr["IDSubject"]);
            IDTeacher = Convert.IsDBNull(dr["IDTeacher"]) ? -1 : Convert.ToInt32(dr["IDTeacher"]);
            CreateAt = Convert.ToDateTime(dr["CreateAt"]);
            NameTopic = dr["NameTopic"].ToString();
            IDKhoi = Convert.IsDBNull(dr["IDKhoi"]) ? -1 : Convert.ToInt32(dr["IDKhoi"]);
        }
    }
}