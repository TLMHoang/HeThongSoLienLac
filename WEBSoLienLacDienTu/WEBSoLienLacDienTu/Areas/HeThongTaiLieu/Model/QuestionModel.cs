using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class QuestionModel
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public int IDQuizTopic { get; set; }
        public int LevelQues { get; set; }

        public QuestionModel(int iD, string question, int iDQuizTopic, int levelQues)
        {
            ID = iD;
            Question = question;
            IDQuizTopic = iDQuizTopic;
            LevelQues = levelQues;
        }

        public QuestionModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Question = dr["Question"].ToString();
            IDQuizTopic = Convert.IsDBNull(dr["IDQuizTopic"]) ? -1 : Convert.ToInt32(dr["IDQuizTopic"]);
            LevelQues = Convert.IsDBNull(dr["LevelQues"]) ? -1 : Convert.ToInt32(dr["LevelQues"]);
        }
    }
}