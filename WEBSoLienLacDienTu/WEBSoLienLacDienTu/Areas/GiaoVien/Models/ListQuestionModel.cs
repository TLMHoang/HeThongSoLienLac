using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.GiaoVien.Models
{
    public class ListQuestionModel
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public int IDAnswer { get; set; }
        public string Answer { get; set; }
        public string ExplainAns { get; set; }
        public byte CorrectAns { get; set; }

        public ListQuestionModel(int iD, string question, int iDAnswer, string answer, string explainAns, byte correctAns)
        {
            ID = iD;
            Question = question;
            IDAnswer = iDAnswer;
            Answer = answer;
            ExplainAns = explainAns;
            CorrectAns = correctAns;
        }

        public ListQuestionModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            Question = dr["Question"].ToString();
            IDAnswer = Convert.IsDBNull(dr["IDAnswer"]) ? -1 : Convert.ToInt32(dr["IDAnswer"]);
            Answer = dr["Answer"].ToString();
            ExplainAns = dr["explainAns"].ToString();
            CorrectAns = Convert.ToByte(dr["CorrectAns"]);
        }
    }
}