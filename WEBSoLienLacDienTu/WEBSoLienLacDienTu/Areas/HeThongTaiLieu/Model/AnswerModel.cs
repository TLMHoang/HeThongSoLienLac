using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class AnswerModel
    {
        public int ID { get; set; }
        public int IDQues { get; set; }
        public string Answer { get; set; }
        public string ExplanAns { get; set; }
        public byte CorrectAns { get; set; }

        public AnswerModel(int iD, int iDQues, string answer, string explanAns, byte correctAns)
        {
            ID = iD;
            IDQues = iDQues;
            Answer = answer;
            ExplanAns = explanAns;
            CorrectAns = correctAns;
        }

        public AnswerModel(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            IDQues = Convert.IsDBNull(dr["IDQues"]) ? -1 : Convert.ToInt32(dr["IDQues"]);
            Answer = dr["Answer"].ToString();
            ExplanAns = dr["ExplanAns"].ToString();
            CorrectAns = Convert.ToByte(dr["CorrectAns"]);
        }
    }
}